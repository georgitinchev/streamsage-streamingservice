using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
	public abstract class Entity
	{
		public int Id { get; protected set; }
		public DateTime CreatedAt { get; protected set; }
	}
}
