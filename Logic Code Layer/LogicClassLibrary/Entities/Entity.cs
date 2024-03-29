using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
	public abstract class Entity
	{
		public int Id { get; protected set; }

		public void GenerateId()
		{
			this.Id = new Random().Next(1, 1000);
		}

		public int GetId()
		{
			return this.Id;
		}
	}
}
