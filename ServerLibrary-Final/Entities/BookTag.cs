using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Entities
{
	internal class BookTag: IEntity<BookTag>
	{
		[Key]
		public int Id { get; set; }
		public int IdBook { get; set; }
		public string IdTag { get; set; }

		public BookTag Clone(BookTag entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(BookTag entity)
		{
			return false;
		}
	}
}
