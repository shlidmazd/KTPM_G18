using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal interface IService
	{
		void Start();
		void Update();
		void Stop();
	}
}
