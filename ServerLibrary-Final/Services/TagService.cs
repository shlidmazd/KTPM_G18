using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal class TagService: CrudService<Tag>
	{
		private static TagService instance = new TagService();
		private TagService() { }
		public static TagService Instance
		{
			get
			{
				return instance;
			}
		}
	}
}
