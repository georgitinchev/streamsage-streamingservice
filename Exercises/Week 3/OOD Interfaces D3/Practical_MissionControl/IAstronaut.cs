using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    public interface IAstronaut
    {
        string Name { get; set; }
        string Gender { get; set; }
        string Nationality { get; set; }
        List<IMission> Missions { get; set; }
    }
}
