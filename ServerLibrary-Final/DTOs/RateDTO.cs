using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.DTOs
{
	[Serializable]
	public class RateDTO
	{
		public string Username { get; set; }
		public float Star { get; set; }
		public string Rate { get; set; }
		public string FullName { get; set; }
		public string ContentRate { get; set; }
	}
}
