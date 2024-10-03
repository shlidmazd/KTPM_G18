using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Entities
{
	internal class Tag : IEntity<Tag>
	{
		[Key]
		public string Id { get; set; }
		public string Name { get; set; }

		public Tag Clone(Tag entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(Tag entity)
		{
			Id = entity.Id;
			Name = entity.Name;
			return true;
		}
	}
}
