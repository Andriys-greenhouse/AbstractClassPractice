using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Sphere s;
            try
            {
                s = new Sphere(-1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            List<Body> bodys = new List<Body>();

            s = new Sphere(5);
            Cube cu = new Cube(s);
            Cylinder cy = new Cylinder(s);
            Cone co = new Cone(s);

            bodys.Add(s);
            bodys.Add(cu);
            bodys.Add(cy);
            bodys.Add(co);

            foreach (Body item in bodys)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
