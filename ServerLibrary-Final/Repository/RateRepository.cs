using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class RateRepository : IRepository<Rate>
	{
		private LibraryContext _context;
		public RateRepository()
		{
			_context = LibraryContext.gI();
		}
		public Rate Add(Rate item)
		{
			_context.Rates.Add(item);
			_context.SaveChanges();
			return item;
		}

		public bool Delete(Rate item)
		{
			Rate rate = _context.Rates.FirstOrDefault(x => x.Id == item.Id);
			if (rate != null)
			{
				_context.Rates.Remove(rate);
				return true;
			}
			return false;
		}

		public Rate FindById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Rate> GetAll()
		{
			return _context.Rates;
		}

		public bool Update(Rate item)
		{
			Rate rate = _context.Rates.FirstOrDefault(m => m.Id == item.Id);
			if (rate != null)
			{
				rate.Update(item);
				return true;
			}
			return false;
		}
	}
}
