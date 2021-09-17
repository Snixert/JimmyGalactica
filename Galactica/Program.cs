using System;
using System.Collections.Generic;
using static Galactica.SpaceObjects;

namespace Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Star star = new Star()
            {
                Id = 1,
                Name = "Sun",
                Temperature = 50,
                Type = Startype.RedGiant,
                PlanetList = new List<Planet>
                {
                    new Planet
                    {
                      Positioning = new Position(){x =  5, y = 2},
                      Id = 1,
                      Name = "Mercury",
                      DiameterInMeters = 10,
                      RevolutionPeriodInDays = 10,
                      RotationPeriodInHours = 10,
                      PlanetType = PlanetType.Giant,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 1, Name = "Luna", Positioning = new Position { x = 12, y = 13 }, Orbiting = new Planet{ Id = 1, Name = "Mercury" } }
                      }
                    },
                    new Planet
                    {
                      Positioning = new Position(){x =  10, y = 5},
                      Id = 2,
                      Name = "Venus",
                      DiameterInMeters = 20,
                      RevolutionPeriodInDays = 20,
                      RotationPeriodInHours = 20,
                      PlanetType = PlanetType.Dwarf,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 2, Name = "Titan", Positioning = new Position { x = 42, y = 9 }, Orbiting = new Planet{ Id = 2, Name = "Venus" } }
                      }
                    },
                    new Planet
                    {
                      Positioning = new Position(){x =  15, y = 7},
                      Id = 3,
                      Name = "Earth",
                      DiameterInMeters = 30,
                      RevolutionPeriodInDays = 30,
                      RotationPeriodInHours = 30,
                      PlanetType = PlanetType.Terrestial,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 3, Name = "Phobos", Positioning = new Position { x = 53, y = 83 }, Orbiting = new Planet{ Id = 3, Name = "Earth" } }
                      }
                    },
                    new Planet
                    {
                      Positioning = new Position(){x =  20, y = 10},
                      Id = 4,
                      Name = "Mars",
                      DiameterInMeters = 40,
                      RevolutionPeriodInDays = 40,
                      RotationPeriodInHours = 40,
                      PlanetType = PlanetType.Terrestial,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 4, Name = "Europe", Positioning = new Position { x = 12, y = 11 }, Orbiting = new Planet{ Id = 4, Name = "Mars" } }
                      }
                    },
                    new Planet
                    {
                      Positioning = new Position(){x =  25, y = 12},
                      Id = 5,
                      Name = "Jupiter",
                      DiameterInMeters = 50,
                      RevolutionPeriodInDays = 50,
                      RotationPeriodInHours = 50,
                      PlanetType = PlanetType.Giant,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 5, Name = "Deimos", Positioning = new Position { x = 51, y = 50 }, Orbiting = new Planet{ Id = 5, Name = "Jupiter" } }
                      }
                    },
                    new Planet
                    {
                      Positioning = new Position(){x =  30, y = 15},
                      Id = 6,
                      Name = "Saturn",
                      DiameterInMeters = 60,
                      RevolutionPeriodInDays = 60,
                      RotationPeriodInHours = 60,
                      PlanetType = PlanetType.Gas_Giant,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 6, Name = "Ganymedes", Positioning = new Position { x = 203, y = 140 }, Orbiting = new Planet{ Id = 6, Name = "Saturn" } }
                      }
                    },
                    new Planet
                    {
                      Positioning = new Position(){x =  35, y = 17},
                      Id = 7,
                      Name = "Uranus",
                      DiameterInMeters = 70,
                      RevolutionPeriodInDays = 70,
                      RotationPeriodInHours = 70,
                      PlanetType = PlanetType.Giant,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 7, Name = "Io", Positioning = new Position { x = 68, y = 99 }, Orbiting = new Planet{ Id = 7, Name = "Uranus" } }
                      }
                    },
                    new Planet
                    {
                      Positioning = new Position(){x =  40, y = 20},
                      Id = 8,
                      Name = "Neptune",
                      DiameterInMeters = 80,
                      RevolutionPeriodInDays = 80,
                      RotationPeriodInHours = 80,
                      PlanetType = PlanetType.Dwarf,
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 8, Name = "Mimas", Positioning = new Position { x = 958, y = 86 }, Orbiting = new Planet{ Id = 8, Name = "Neptune" } }
                      }
                    }
                }
            };

            Planet planetRef = new Planet();
            planetRef.ShowAllPlanetsAndMoons(star);

        }
    }
}
