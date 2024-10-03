using ServerLibrary.DTOs;
using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal class ReadStatusService: CrudService<ReadingStatus>
	{
		private static ReadStatusService instance = new ReadStatusService();
		private ReadStatusService() { }
		public static ReadStatusService GetInstance()
		{
			return instance;
		}
		public bool MarkFavorite(int IDBook, User user)
		{
			var old = FirstOrDefault(m => m.IdBook == IDBook && m.IdUser == user.Id);
			bool result;
			if(old != null)
			{
				old.IsFavorite = !old.IsFavorite;
				Update(old);
				result = old.IsFavorite;
			}
			else
			{
				var readStatus = new ReadingStatus()
				{
					IsFavorite = true,
					IdBook = IDBook,
					IdUser = user.Id,
					IsReading = false
				};
				Add(readStatus);
				result = true;
			}
			return result;
		}
		public void MarkReading(int IDBook, User user)
		{
			var old = FirstOrDefault(m => m.IdBook == IDBook && m.IdUser == user.Id);
			if (old != null)
			{
				old.IsReading = !old.IsReading;
				Update(old);
			}
			else
			{
				var readStatus = new ReadingStatus()
				{
					IsFavorite = false,
					IdBook = IDBook,
					IdUser = user.Id,
					IsReading = true
				};
				Add(readStatus);
			}
		}
	}
}
