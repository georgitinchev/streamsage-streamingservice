using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
	public abstract class Entity
	{
		public virtual int Id { get; set; }
		public virtual DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}
