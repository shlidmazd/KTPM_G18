using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class Pagination
	{
		public int Skip { get; set; } = 0;
		public int Take { get; set; } 
		private Pagination(int page, int itemPerPage)
		{
			this.Take = itemPerPage;
			this.Skip = (page - 1) * itemPerPage;
		}
		public static Pagination Paging(int page, int itemPerPage)
		{
			return new Pagination(page, itemPerPage);
		}
	}
}
