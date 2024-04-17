using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_MissionControl
{
    public interface IMission
    {
        string Name { get; set; }
        DateTime LaunchDate { get; set; }
        DateTime ReturnDate { get; set; }
        string SpaceshipType { get; set; }
        List<IAstronaut> Astronauts { get; set; }
    }
}
