using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServerLibrary.Utils
{
	internal class StringUtil
	{
		public static bool ValidateString(string input)
		{
			string pattern = @"^[a-zA-Z0-9]{1,50}$";
			if (string.IsNullOrEmpty(input))
			{
				return false;
			}
			return Regex.IsMatch(input, pattern);
		}
	}
}
