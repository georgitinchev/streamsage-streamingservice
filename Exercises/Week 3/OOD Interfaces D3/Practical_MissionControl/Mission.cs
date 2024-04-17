using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    public abstract class MissionBase : IMission
    {
        public string Name { get; set; }
        public DateTime LaunchDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string SpaceshipType { get; set; }
        public List<IAstronaut> Astronauts { get; set; }
    }
}
