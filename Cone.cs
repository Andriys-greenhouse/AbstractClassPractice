using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    class Cone : Body //česky kužel
    {
        double baseRadius;
        public double BaseRadius
        {
            get { return baseRadius; }
            set
            {
                if (value > 0) { baseRadius = value; }
                else { throw new ArgumentException("Radius of the base of the cone must be greather than zero!"); }
            }
        }

        double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value > 0) { height = value; }
                else { throw new ArgumentException("Height of the cone must be greather than zero!"); }
            }
        }

        public Cone(double aBaseRadius, double aHeight)
        {
            BaseRadius = aBaseRadius;
            Height = aHeight;
        }

        public Cone(Body aHasVolume)
        {
            Height = 1;
            BaseRadius = Math.Pow(aHasVolume.Volume() * 3 / Math.PI, 1 / 2);
        }

        public override double Surface() 
        {
            double shellHeight = Math.Sqrt(Math.Pow(BaseRadius, 2) + Math.Pow(Height, 2));
            return Math.PI * Math.Pow(BaseRadius, 2) + 
                (Math.PI * Math.Pow(shellHeight, 2) * (2 * Math.PI * BaseRadius)) /(2 * Math.PI * shellHeight); 
        }

        public override double Volume() { return Math.PI * Math.Pow(BaseRadius, 2) * Height / 3; }

    }
}
