using ServerLibrary.Entities;
using ServerLibrary.Services;
using ServerLibrary.State;
using ServerLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class BookRepository: IRepository<Book>
	{
		private LibraryContext _context;
		public BookRepository()
		{
			this._context = LibraryContext.gI();
		}

		public IEnumerable<Book> GetBooks()
		{
			return this._context.Books;
		}
		public Book Add(Book item)
		{
			_context.Books.Add(item);
			_context.SaveChanges();
			return item;
		}

		public bool Delete(Book item)
		{
			Book book = _context.Books.FirstOrDefault(x => x.Id == item.Id);
			if(book != null)
			{
				_context.Books.Remove(book);
				return true;
			}
			return false;
		}

		public IEnumerable<Book> Filter(FilterCriteria filter)
		{
			if (filter == null)
			{
				return _context.Books;
			}
			int start = filter.StarRange[0];
			int end = filter.StarRange[1];
			IQueryable<Book> result = _context.Books;
			result = result.Where(item => item.Star >= start && item.Star <= end);
			bool isDesending = filter.Sort.SortType != null && filter.Sort.SortType == SortType.Descending;
			if (filter.Sort.SortBy != null)
			{
				switch (filter.Sort.SortBy)
				{
					case SortBy.Star:
						{
							if(isDesending)
							{
								result = result.OrderByDescending(x => x.Star);
							}
							else
							{
								result = result.OrderBy(x => x.Star);
							}
							break;
						}
					case SortBy.ViewCount:
						{
							if (isDesending)
							{
								result = result.OrderByDescending(x => x.ViewCount);
							}
							else
							{
								result = result.OrderBy(x => x.ViewCount);
							}
							break;
						}
					case SortBy.Recommend:
						{
							int rcm = 5 > result.Count() ? result.Count() : 5;
							List<Book> books = result.ToList();
							books = (List<Book>)RandomUtil.GetRandomElements(books, rcm);
							return books;
						}
					case SortBy.Favorite:
						{
							List<Book> books = new List<Book>();
							var listFavorites = ReadStatusService.GetInstance()
								.Where(m => m.IsFavorite && m.IdUser == AppState.Instance.User.Id)
								.Select(m => m.IdBook);
							var listBooks = BookService.GetInstance().Where(m => listFavorites.Contains(m.Id));
							return listBooks;
						}
					case SortBy.Reading:
						{
							List<Book> books = new List<Book>();
							var listReading = ReadStatusService.GetInstance()
								.Where(m => m.IsReading && m.IdUser == AppState.Instance.User.Id)
								.Select(m => m.IdBook);
							var listBooks = BookService.GetInstance().Where(m => listReading.Contains(m.Id));
							return listBooks;
						}
				}
			}
			return result.ToList();
		}

		public Book FindById(int id)
		{
			Book book = _context.Books.FirstOrDefault(item => item.Id == id);
			return book;
		}

		public bool Update(Book item)
		{
			Book current = _context.Books.FirstOrDefault(book => book.Id == item.Id);
			if(current != null)
			{
				current.Update(item);
				_context.SaveChanges();
				return true;
			}
			return false;
		}

		public IEnumerable<Book> GetAll()
		{
			return _context.Books;
		}
	}
}
