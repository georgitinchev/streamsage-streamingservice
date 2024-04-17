using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    public abstract class AstronautBase : IAstronaut
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public List<IMission> Missions { get; set; }
    }
}
