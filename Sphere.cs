using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    class Sphere : Body
    {
        double radius;
        public double Radius
        {
            get { return radius; }
            set
            {
                if (value > 0) { radius = value; }
                else { throw new ArgumentException("Radius of the sphere must be greather than zero!"); }
            }
        }

        public override double Surface() { return 4 * Math.PI * Math.Pow(Radius, 2); }
        public override double Volume() { return 4 * Math.PI * Math.Pow(Radius, 3) / 3; }
    }
}
