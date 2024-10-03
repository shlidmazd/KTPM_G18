using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class BookTagRepository : IRepository<BookTag>
	{
		private LibraryContext _context;
		public BookTagRepository()
		{
			this._context = LibraryContext.gI();
		}

		public IEnumerable<Book> GetAll()
		{
			return _context.Books;
		}

		BookTag IRepository<BookTag>.FindById(int id)
		{
			throw new NotImplementedException();
		}

		public BookTag Add(BookTag item)
		{
			_context.BookTags.Add(item);
			_context.SaveChanges();
			return item;
		}

		IEnumerable<BookTag> IRepository<BookTag>.GetAll()
		{
			return _context.BookTags;
		}

		public bool Update(BookTag item)
		{
			throw new NotImplementedException();
		}

		public bool Delete(BookTag item)
		{
			BookTag book = _context.BookTags.FirstOrDefault(x => x.Id == item.Id);
			if (book != null)
			{
				_context.BookTags.Remove(book);
				return true;
			}
			return false;
		}
	}
}
