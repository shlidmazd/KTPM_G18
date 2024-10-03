using ServerLibrary.Entities;
using ServerLibrary.Repository.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class FilterCriteria
	{
		public string Keyword { get; set; } = string.Empty;
		public int[] StarRange { get; set; } = new int[2] { 0, 5 };
		public List<Tag> Tags { get; set; } = new List<Tag>();
		public Pagination Pagination { get; set; } = Pagination.Paging(1, 10);
		public SortCriteria Sort { get; set; }
		public FilterCriteria(FilterBuilder builder)
		{
			this.StarRange = builder.StarRange;
			this.Tags = builder.Tags;
			this.Keyword = builder.Keyword;
			this.Sort = builder.SortCriteria;
		}
	}
}
