using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Utils
{
	internal class LogUtil
	{
		public static bool debug = true;
		public static void Debug(object obj)
		{
			if(debug)
            Console.WriteLine(obj.ToString());
        }
	}
}
