using ServerLibrary.DTOs;
using ServerLibrary.Entities;
using ServerLibrary.Services;
using ServerLibrary.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Extensions
{
	internal static class BookExtension
	{
		public static BookDTO ToDTO(this Book book)
		{
			BookDTO bookDTO = new BookDTO()
			{
				Author = book.Author,
				Description = book.Description,
				Id = book.Id,
				Rate = book.Star,
				Title = book.Title,
				Image = book.Image,
				ViewCount = book.ViewCount,
				ChapterFolder = book.ChapterFolder,
				StartChapter = book.StartChapter,
				EndChapter = book.EndChapter,
			};
			var listTag = BookTagService.Instance
				.Where(m => m.IdBook == book.Id)
				.Select(m => m.IdTag);
			var tagToStr = TagService.Instance.Where(m => listTag.Contains(m.Id.Trim()));
			bookDTO.Tag = string.Join(", ",tagToStr.Select(m => m.Name).ToArray());
			bookDTO.Rates = RateService.Instance.Where(m => m.IdBook == book.Id).GetRatesDTO().ToList();
			bookDTO.IsFavorite = ReadStatusService.GetInstance().FirstOrDefault(m => m.IsFavorite && 
			m.IdBook == book.Id && m.IdUser == AppState.Instance.User.Id) != null;
			return bookDTO;
		}

	}
}
