using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal interface IRepository<T>
	{
		T FindById(int id);
		T Add(T item);
		IEnumerable<T> GetAll();
		bool Update(T item);
		bool Delete(T item);
	}
}
