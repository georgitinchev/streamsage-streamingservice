using LogicClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Managers
{
	public class GeneralManager<T> where T : Entity
	{
		public List<T> entities = new List<T>();
		public virtual void Add(T entity)
		{
			entities.Add(entity);
		}

		public virtual void Remove(T entity)
		{
			entities.Remove(entity);
		}

		public virtual void Update(T entity)
		{
			// Default update logic here
		}

		public virtual T Get(int id)
		{
			return entities.FirstOrDefault(e => e.GetId() == id);
		}

		public virtual List<T> Search(Func<T, bool> predicate)
		{
			return entities.Where(predicate).ToList();
		}
	}
}
