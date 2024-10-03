using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.State
{
	internal class AppState
	{
		private AppState() { }
		private static AppState instance = new AppState();
		public static AppState Instance { get {  return instance; } }

		public User User { get; set; } = new User();
		/*{
			Id = 1,
			Address = "Hà Nội",
			Birth = DateTime.Now,
			FullName = "",
			Username = "admin"
		};*/
	}
}
