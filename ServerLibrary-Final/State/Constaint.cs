using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Common
{
	internal abstract class Constaint
	{
		//User
		public const byte LOGIN = 0; //ok
		public const byte REGISTER = 1; //ok
		
		//Book
		public const byte GET_RECOMMEND_BOOKS = 2;
		public const byte GET_RANKING_BOOKS = 3;
		public const byte GET_DETAIL_BOOK = 4;
		public const byte ACT_FAVORITE_BOOK = 6;
		public const byte ACT_RATE_BOOK = 7;


	}
}
