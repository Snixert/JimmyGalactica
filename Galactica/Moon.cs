using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    sealed class Moon : Planet
    {
        public Planet Orbiting {  get; set; }

        public double Distance(Planet p, Moon m)
        {
            double distance = Math.Sqrt(Math.Pow((p.Positioning.x - m.Positioning.x), 2) + Math.Pow((p.Positioning.y - m.Positioning.y), 2));
            return distance;
        }
    }
}
