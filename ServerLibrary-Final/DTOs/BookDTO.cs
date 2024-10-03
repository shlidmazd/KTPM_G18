using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.DTOs
{
	[Serializable]
	public class BookDTO
	{
		public BookDTO() { }
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }
		public double Rate { get; set; }
		public string Tag { get; set; }
		public string Image { get; set; }
		public bool IsFavorite { get; set; }
		public int ViewCount { get; set; }
		public string ChapterFolder { get; set; }
		public int StartChapter { get; set; }
		public int EndChapter { get; set; }
		public List<RateDTO> Rates { get; set; }
	}
}
