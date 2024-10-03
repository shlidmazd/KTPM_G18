using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository.Common
{
	internal class FilterBuilder
	{
		public FilterBuilder() { }
		public string Keyword { get; set; } = string.Empty;
		public int[] StarRange = new int[2] { 0, 5 };
		public List<Tag> Tags { get; set; } = new List<Tag>();
		public SortCriteria SortCriteria { get; set; } = new SortCriteria();
		public FilterBuilder ByKeyword(string keyword) 
		{
			this.Keyword = keyword;
			return this;
		}
		public FilterBuilder ByRangeStar(int start, int end)
		{
			end = end >= start ? end : start;
			this.StarRange[0] = start < 0 ? 0 : start;
			this.StarRange[1] = end > 5 ? 5 : end;
			return this;
		}
		public FilterBuilder ByTag(List<Tag> tags)
		{
			this.Tags = tags;
			return this;
		}
		public FilterBuilder SortBy(SortBy sortBy)
		{
			this.SortCriteria.SortBy = sortBy;
			return this;
		}
		public FilterBuilder SortType(SortType sortType)
		{
			this.SortCriteria.SortType = sortType;
			return this;
		}

		public FilterCriteria Build()
		{
			return new FilterCriteria(this);
		}
	}
}
