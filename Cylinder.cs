using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    class Cylinder : Body //česky válec
    {
        double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { throw new ArgumentException("Height of the cylinder must be greather than zero!"); }
            }
        }

        double baseRadius;
        public double BaseRadius
        {
            get { return baseRadius; }
            set
            {
                if (value > 0) { baseRadius = value; }
                else { throw new ArgumentException("Radius of the base of the cylinder must be greather than zero!"); }
            }
        }

        public Cylinder(double aBaseRadius, double aHeight)
        {
            BaseRadius = aBaseRadius;
            Height = aHeight;
        }

        public Cylinder(Body aHasVolume)
        {
            Height = 1;
            BaseRadius = Math.Pow(aHasVolume.Volume() / Math.PI, 1 / 2);
        }


        public override double Surface() { return  2 * Math.PI * BaseRadius * (BaseRadius + Height); }
        public override double Volume() { return Math.PI * Math.Pow(BaseRadius, 2) * Height; }

        public override string ToString()
        {
            return $"Cylinder:\n  Height: {Height}\n  Base radius: {BaseRadius}\n  Surface to volume ratio: {SurfaceToVolumeRatio()}\n";
        }
    }
}
