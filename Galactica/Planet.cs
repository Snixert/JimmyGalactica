using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    enum PlanetType
    {
        Terrestial,
        Giant,
        Dwarf,
        Gas_Giant
    }
    class Planet : SpaceObjects
    {
        public double DiameterInMeters {  get; set; }
        public double RotationPeriodInHours { get; set; }
        public double RevolutionPeriodInDays { get; set; }
        public List<Moon> MoonList = new List<Moon>();

        public double Distance(Star solarSystem)
        {
            foreach (var planet in solarSystem.PlanetList)
            {
                Console.WriteLine(planet.Name);
            }






            double distance = 0;
            return distance;
            //double Distance = Math.Sqrt(Math.Pow(second.x - first.x, 2) + Math.Pow(second.y - first.y, 2));
            //return Distance;
        }

    }
}
