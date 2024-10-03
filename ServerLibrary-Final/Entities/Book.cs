using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Entities
{
	internal class Book: IEntity<Book>
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }
		public double Star { get; set; } = 0.0f;
		public string ChapterFolder { get; set; }
		public int StartChapter { get; set; } = 0;
		public int EndChapter { get; set; }
		public int ViewCount { get; set; } = 0;
		public Book Clone(Book entity)
		{
			return new Book()
			{
				Id = entity.Id,
				Title = entity.Title,
				Description = entity.Description,
				Author = entity.Author,
				Star = entity.Star,
				ChapterFolder = entity.ChapterFolder,
				ViewCount = entity.ViewCount,
			};
		}

		public bool ContainKeyword(string keyword)
		{
			string[] tmp = new string[] { Title, Description, Author, ChapterFolder};
            foreach (var item in tmp)
            {
				if (item.Contains(keyword.ToLower()))
				{
					return true;
				}
            }
			return false;
		}

		public bool Update(Book entity)
		{
			try
			{
				Title = entity.Title;
				Description = entity.Description;
				Author = entity.Author;
				Star = entity.Star;
				ChapterFolder = entity.ChapterFolder;
				ViewCount = entity.ViewCount;
				StartChapter = entity.StartChapter;
				EndChapter = entity.EndChapter;
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
