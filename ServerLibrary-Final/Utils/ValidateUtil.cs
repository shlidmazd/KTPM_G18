using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ServerLibrary.Utils
{
	internal class ValidateUtil
	{
		public static bool ValidateString(string input, string pattern)
		{
			if (string.IsNullOrEmpty(input) || string.IsNullOrEmpty(pattern))
			{
				return false;
			}
			return Regex.IsMatch(input, pattern);
		}
		public static bool IsOnlyTextAndNumber(string input)
		{
			return ValidateString(input, "^[a-zA-Z0-9]{1,50}$");
		}
	}
}
