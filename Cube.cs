using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    class Cube : Body
    {
        double edge;
        public double Edge
        {
            get { return edge; }
            set
            {
                if (value > 0) { edge = value; }
                else { throw new ArgumentException("Edge of the cube must be greather than zero!"); }
            }
        }

        public Cube(double aEdge)
        {
            Edge = aEdge;
        }

        public Cube(Body aHasVolume)
        {
            Edge = Math.Pow(aHasVolume.Volume(), 1/3);
        }


        public override double Surface() { return 6 * Math.Pow(Edge, 2); }
        public override double Volume() { return Math.Pow(Edge, 3); }
    }
}
