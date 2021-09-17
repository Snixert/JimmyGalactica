using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    public enum PlanetType
    {
        Terrestial,
        Giant,
        Dwarf,
        Gas_Giant
    }
    class Planet : SpaceObjects
    {
        public double DiameterInMeters { get; set; }
        public double RotationPeriodInHours { get; set; }
        public double RevolutionPeriodInDays { get; set; }
        public PlanetType PlanetType { get; set; }
        public List<Moon> MoonList = new List<Moon>();

        public double Distance(Star solarSystem, Planet planet)
        {
            double distance = Math.Sqrt(Math.Pow((planet.Positioning.x - solarSystem.Positioning.x), 2) + Math.Pow((planet.Positioning.y - solarSystem.Positioning.y), 2));
            return distance;
        }

        public void ShowAllPlanetsAndMoons(Star solarSystem)
        {
            foreach (var planet in solarSystem.PlanetList)
            {
                Console.WriteLine($"Planet: {planet.Name}\nPosition {planet.Positioning.ToString()}\nDistance from {solarSystem.Name}: {Distance(solarSystem, planet):N2}");
                Console.WriteLine($"Planet type: {planet.PlanetType}");

                foreach (var moon in planet.MoonList)
                {
                    Console.WriteLine($"       Moon: {moon.Name} | Orbiting: {moon.Orbiting.Name} | Position: {moon.Positioning} | Distance from {moon.Orbiting.Name}: {moon.Distance(planet, moon):N2}");
                    
                }
                Console.WriteLine("\n---------------------------------------------");
            }
        }
    }
}
