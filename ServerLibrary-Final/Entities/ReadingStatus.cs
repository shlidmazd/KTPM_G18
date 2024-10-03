using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Entities
{

	internal class ReadingStatus: IEntity<ReadingStatus>
	{
		[Key]
		public int Id { get; set; }
		public int IdUser { get; set; }
		public int IdBook { get; set; }
		public bool IsFavorite { get; set; }
		public bool IsReading { get; set; } = false;

		public ReadingStatus Clone(ReadingStatus entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(ReadingStatus entity)
		{
			try
			{
				IsFavorite = entity.IsFavorite;
				IsReading = entity.IsReading;
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
