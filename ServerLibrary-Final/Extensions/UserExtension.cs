using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services.Extensions
{
	internal static class UserExtension
	{
		public static List<Tag> GetFavoriteTags(this User user)
		{
			var listTag = new List<Tag>();
			var listFavoriteBooks = ReadStatusService.GetInstance()
				.Where(item => item.IdUser == user.Id)
				.Select(item => item.IdBook)
				.ToList();
			var listTags = BookTagService.Instance
				.Where(m => listFavoriteBooks.Contains(m.IdBook))
				.Select(m => m.IdTag);
			return listTag;
		}
	}
}
