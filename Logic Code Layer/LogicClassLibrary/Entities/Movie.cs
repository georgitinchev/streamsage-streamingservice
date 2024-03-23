using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Entities
{
	public class Movie : Entity
	{
		public int Id { get; set; }
		public string? Title { get; set; }
		public int Year { get; set; }
	}
}
