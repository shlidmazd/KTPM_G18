using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Utils
{
	internal class RandomUtil
	{
		public static IEnumerable<T> GetRandomElements<T>(IEnumerable<T> source, int count)
		{
			Random random = new Random();
			var randomElements = source.OrderBy(x => random.Next()).Take(count).ToList();
			randomElements = randomElements.OrderBy(x => random.Next()).ToList();
			return randomElements;
		}
	}
}
