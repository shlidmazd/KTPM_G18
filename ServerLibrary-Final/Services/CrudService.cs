using ServerLibrary.Entities;
using ServerLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary.Services
{
	internal abstract class CrudService<EntityType> : IService
	{
		protected IRepository<EntityType> _repository;
		public CrudService()
		{
			Type type = typeof(EntityType);
			if (type == typeof(Book))
			{
				_repository = (IRepository<EntityType>)new BookRepository();
			}
			else if (type == typeof(Rate))
			{
				_repository = (IRepository<EntityType>)new RateRepository();
			}
			else if (type == typeof(ReadingStatus))
			{
				_repository = (IRepository<EntityType>)new ReadingStatusRepository();
			}
			else if (type == typeof(Tag))
			{
				_repository = (IRepository<EntityType>)new TagRepository();
			}
			else if (type == typeof(User))
			{
				_repository = (IRepository<EntityType>)new UserRepository();
			}
			else if(type == typeof(BookTag))
			{
				_repository = (IRepository<EntityType>)new BookTagRepository();
			}
		}

		public EntityType Add(EntityType entity)
		{
			return _repository.Add(entity);
		}
		public bool Update(EntityType new_entity)
		{
			return _repository.Update(new_entity);
		}
		public IEnumerable<EntityType> Where(Func<EntityType, bool> predicate)
		{
			List<EntityType> entities = new List<EntityType>();
			foreach(var e in _repository.GetAll())
			{
				if(predicate(e)) entities.Add(e);
			}
			return entities;
		}
		public int Delete(Func<EntityType, bool> predicate)
		{
			int cnt = 0;
			foreach (var item in _repository.GetAll())
			{
				if (predicate(item))
				{
					cnt += _repository.Delete(item) ? 1 : 0;
				}
			}
			return cnt;
		}
		public bool DeleteFirst(Func<EntityType, bool> predicate)
		{
			foreach (var item in _repository.GetAll())
			{
				if (predicate(item))
				{
					return _repository.Delete(item);
				}
			}
			return false;
		}
		public bool DeleteFirst(EntityType entity)
		{
			return _repository.Delete(entity);
		}
		public EntityType FirstOrDefault(Func<EntityType, bool> predicate)
		{
			foreach (var item in _repository.GetAll())
			{
				if (predicate(item))
					return item;
			}
			return default;
		}

		public IEnumerable<EntityType> GetAll()
		{
			return _repository.GetAll();
		}

		public TRepo Cast<TRepo>()
		{
			return (TRepo)_repository;
		}

		public void Start()
		{
			
		}

		public void Update()
		{
			throw new NotImplementedException();
		}

		public void Stop()
		{
			_repository = null;
		}
	}
}
