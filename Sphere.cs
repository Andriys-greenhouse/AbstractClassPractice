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

        public Sphere(double aRadius)
        {
            Radius = aRadius;
        }

        public Sphere(Body aHasVolume)
        {
            Radius = Math.Pow(aHasVolume.Volume() * 3 / (4 * Math.PI), 1 / 3);
        }



        public override double Surface() { return 4 * Math.PI * Math.Pow(Radius, 2); }
        public override double Volume() { return 4 * Math.PI * Math.Pow(Radius, 3) / 3; }

        public override string ToString()
        {
            return $"Sphere:\n  Radius: {Radius}\n  Surface to volume ratio: {SurfaceToVolumeRatio()}\n";
        }
    }
}
