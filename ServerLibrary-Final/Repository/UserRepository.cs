using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class UserRepository: IRepository<User>
	{
		private LibraryContext _context;
		public UserRepository()
		{
			_context = LibraryContext.gI();
		}

		public User Add(User item)
		{
			_context.Users.Add(item);
			_context.SaveChanges();
			return item;
		}

		public bool Delete(User item)
		{
			User user = _context.Users.FirstOrDefault(x => x.Id == item.Id);
			if (user != null)
			{
				_context.Users.Remove(user);
				return true;
			}
			return false;
		}

		public User FindById(int id)
		{
			return _context.Users.FirstOrDefault(m => m.Id == id);
		}

		public IEnumerable<User> GetAll()
		{
			return _context.Users;
		}

		public int GetRateOfUser(int bookId)
		{
			var rate = _context.Rates.FirstOrDefault(item => item.IdBook == bookId);
			if (rate == null)
			{
				return 0;
			}
			return rate.Star;
		}
		public bool Update(User item)
		{
			User user = _context.Users.FirstOrDefault(m => m.Id == item.Id);
			if (user != null)
			{
				user.Update(item);
				return true;
			}
			return false;
		}

	}
}
