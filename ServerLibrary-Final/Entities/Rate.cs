using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Entities
{
	internal class Rate : IEntity<Rate>
	{
		[Key]
		public int Id { get; set; }
		public int IdUser { get; set; }
		public int IdBook { get; set; }
		public byte Star { get; set; }
		public string ContentRate { get; set; }

		public Rate Clone(Rate entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(Rate entity)
		{
			try
			{
				this.Star = entity.Star;
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}
