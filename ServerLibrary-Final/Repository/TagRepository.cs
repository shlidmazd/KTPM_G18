using ServerLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Repository
{
	internal class TagRepository : IRepository<Tag>
	{
		private readonly LibraryContext _context;
		public TagRepository()
		{
			_context = LibraryContext.gI();
		}
		public Tag Add(Tag item)
		{
			_context.Tags.Add(item);
			_context.SaveChanges();
			return item;
		}

		public bool Delete(Tag item)
		{
			var old = _context.Tags.FirstOrDefault(x => x.Id == item.Id);
			if(old != null)
			{
				_context.Tags.Remove(old);
				_context.SaveChanges();
				return true;
			}
			return false;
		}

		public Tag FindById(int id)
		{
			throw new NotImplementedException();
		}

		public Tag FindById(string id)
		{
			var result = _context.Tags.FirstOrDefault(m => m.Id.Equals(id, StringComparison.OrdinalIgnoreCase));
			return result;
		}

		public IEnumerable<Tag> GetAll()
		{
			return _context.Tags;
		}

		public bool Update(Tag item)
		{
			var old = _context.Tags.FirstOrDefault(o => o.Id == item.Id);
			if(old != null)
			{
				old.Update(item);
				_context.SaveChanges();
				return true;
			}
			return false;
		}
	}
}
