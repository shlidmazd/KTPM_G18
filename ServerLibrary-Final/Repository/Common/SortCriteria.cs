using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	[Serializable]
	internal enum SortBy
	{
		ViewCount,
		Star,
		Favorite,
		Recommend,
		Reading
	}
	[Serializable]
	internal enum SortType
	{
		Ascending,
		Descending
	}
	[Serializable]
	internal class SortCriteria
	{
		public SortType? SortType { get; set; } 
		public SortBy? SortBy { get; set; } 

	}
}
