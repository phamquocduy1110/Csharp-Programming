using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_29_10_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            //Console.WriteLine("The Circle Has Radius Of {0} And Area Of {1}", c1.getRadius(), c1.getArea());

            Circle c2 = new Circle(2);
            //Console.WriteLine("The Circle Has Radius Of {0} And Area Of {2}", c2.getRadius(), c2.getArea());

            Circle c3 = new Circle(3, "Orange");
            //Console.WriteLine("The Circle Has Radius Of {0} And Area Of {3}", c3.getRadius(), c3.Color);

            Circle c4 = new Circle();
            Console.WriteLine("The Circle Has Radius OF {0} And Area Of {1}", c4.getRadius(), "blue");
            //c4.getRadius(10);
            
            Console.WriteLine(c4.ToString());

        }
    }
}
