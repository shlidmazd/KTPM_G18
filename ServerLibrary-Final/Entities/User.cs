using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Entities
{
	[Serializable]
	public class User: IEntity<User>
	{
		[Key]
		public int Id { get; set; }
		public string FullName { get; set; } = string.Empty;
		public DateTime? Birth {  get; set; }
		public string Address { get; set; } = string.Empty;
		public string Username { get; set; } = string.Empty ;
		public string Password { get; set; } = string.Empty;

		public User Clone(User entity)
		{
			throw new NotImplementedException();
		}

		public bool Update(User entity)
		{
			FullName = entity.FullName;
			Birth = entity.Birth;
			Address = entity.Address;
			return true;
		}
	}
}
