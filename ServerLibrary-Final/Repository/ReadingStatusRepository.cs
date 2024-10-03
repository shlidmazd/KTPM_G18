using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class ReadingStatusRepository : IRepository<ReadingStatus>
	{
		private LibraryContext _context;
		public ReadingStatusRepository() 
		{
			_context = LibraryContext.gI();
		}
		public ReadingStatus Add(ReadingStatus item)
		{
			_context.ReadingStatus.Add(item);
			_context.SaveChanges();
			return item;
		}

		public bool Delete(ReadingStatus item)
		{
			var old = _context.ReadingStatus.FirstOrDefault(i => i.Id == item.Id);
			if(old == null)
			{
				return false;
			}
			_context.ReadingStatus.Remove(old);
			return true;
		}

		public ReadingStatus FindById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<ReadingStatus> GetFavorite()
		{
			return _context.ReadingStatus.Where(item => item.IsFavorite);
		}

		public bool Update(ReadingStatus item)
		{
			var old = _context.ReadingStatus.FirstOrDefault(i => i.Id == i.Id);
			if(old == null)
			{
				return false;
			}
			var res = old.Update(item);
			_context.SaveChanges();
			return res;
		}

		public IEnumerable<ReadingStatus> GetAll()
		{
			return _context.ReadingStatus;
		}
	}
}
