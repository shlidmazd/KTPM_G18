using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal class UserService : CrudService<User>
	{
		private UserService() { }
		private static readonly UserService Instance = new UserService();
		public static UserService GetInstance() { return Instance; }
		public int GetSize()
		{
			return this.GetAll().Count();
		}

		public User Login(string username, string password)
		{
			var user = FirstOrDefault(m => m.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && m.Password.Equals(password));
			return user;
		}

		public User Register(User user)
		{
			var exist = FirstOrDefault(m => m.Username.Equals(user.Username,StringComparison.OrdinalIgnoreCase));
			if (exist != null) return null;
			Add(user);
			return user;
		}
	}
}
