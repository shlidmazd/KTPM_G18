using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal class BookTagService: CrudService<BookTag>
	{
		private static BookTagService instance = new BookTagService();
		private BookTagService() { }
		public static BookTagService Instance
		{
			get
			{
				return instance;
			}
		}
	}
}
