using ServerLibrary.Entities;
using ServerLibrary.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal class RateService: CrudService<Rate>
	{
		private static RateService instance = new RateService();
		private RateService() { }
		public static RateService Instance 
		{ 
			get
			{
				return instance;
			} 
		}
		public bool RateBook(Rate rate)
		{
			var old_rate = FirstOrDefault(m => m.IdBook == rate.IdBook && m.IdUser == AppState.Instance.User.Id);
			if(old_rate != null)
			{
				return false;
			}
			var lengthRates = Where(m => m.IdBook == rate.IdBook).Count();
			lengthRates =  lengthRates == 0 ? 1 : lengthRates;
			Add(rate);
			var currentBook = BookService.GetInstance().FirstOrDefault(m => m.Id == rate.IdBook);
			if(currentBook != null)
			{
				currentBook.Star = (currentBook.Star * lengthRates + rate.Star) / (lengthRates + 1);
				BookService.GetInstance().Update(currentBook);
			}
			return true;
		}
		public double GetRate(int idBook)
		{
			var book = BookService.GetInstance().FirstOrDefault(m => m.Id == idBook);
			if(book != null)
			{
				return book.Star;
			}
			return 0.0;
		}
	}
}
