using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    public abstract class Body
    {
        public abstract double Surface();
        public abstract double Volume();
        public double SurfaceToVolumeRatio()
        {
            return Surface() / Volume();
        }
    }
}
