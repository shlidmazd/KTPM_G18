using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Entities
{
	internal interface IEntity<T>
	{
		T Clone(T entity);
		bool Update(T entity);
	}
}
