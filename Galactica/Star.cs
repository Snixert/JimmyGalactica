using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{

    class Star : SpaceObjects
    {
        public Startype Type { get; set; }
        public double Temperature { get; set; }
        public List<Planet> PlanetList = new List<Planet>();
        public override Position Positioning
        {
            get { return new Position() { x = 0, y = 0 }; }
        }

    }
}
