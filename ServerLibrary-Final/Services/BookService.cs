using ServerLibrary.Entities;
using ServerLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal class BookService: CrudService<Book>
	{
		private static BookService bookService = new BookService();
		private BookService() { }
		public static BookService GetInstance()
		{
			return bookService;
		}
		public IEnumerable<Book> Filter(FilterCriteria filter) 
		{
			return Cast<BookRepository>().Filter(filter);
		}

		public void IncreaseView(int idBook)
		{
			var book = FirstOrDefault(m => m.Id == idBook);
			if(book != null)
			{
				book.ViewCount++;
				Update(book);
			}
		}
	}
}
