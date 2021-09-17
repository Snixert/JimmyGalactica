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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 1, Name = "Luna", Orbiting = new Planet{ Id = 1, Name = "Mercury" } }
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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 2, Name = "Titan", Orbiting = new Planet{ Id = 2, Name = "Venus" } }
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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 3, Name = "Phobos", Orbiting = new Planet{ Id = 3, Name = "Earth" } }
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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 4, Name = "Europe", Orbiting = new Planet{ Id = 4, Name = "Mars" } }
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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 5, Name = "Deimos", Orbiting = new Planet{ Id = 5, Name = "Jupiter" } }
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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 6, Name = "Ganymedes", Orbiting = new Planet{ Id = 6, Name = "Saturn" } }
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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 7, Name = "Io", Orbiting = new Planet{ Id = 7, Name = "Uranus" } }
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
                      MoonList = new List<Moon>
                      {
                          new Moon{ Id = 8, Name = "Mimas", Orbiting = new Planet{ Id = 8, Name = "Neptune" } }
                      }
                    }
                }
            };

            Planet planetRef = new Planet();
            planetRef.Distance(star);

        }
    }
}
