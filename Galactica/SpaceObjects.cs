using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galactica
{
    enum Startype 
    {
        YellowDwarf,
        White,
        BlueNeutron,
        RedGiant
    }
    public abstract class SpaceObjects
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Position Positioning { get; set; }
        public class Position
        {
            public int x { get; set; }
            public int y { get; set; }

            public override string ToString()
            {
                return $"({x},{y})";
            }
        }
    }
}
