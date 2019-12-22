using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_29_10_2019
{
    public class Circle
    {
        private double radius;
        private string color;

        public string Color
        {
            get
            {
                return this.Color;
            }
            set
            {
                this.Color = value;
            }
        }

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double r, string c)
        {
            radius = r;
            color = c;
        }

        public Circle(double r)
        {
            radius = r;
            color = "red";
        }

        public double getRadius()
        {
            return radius;
        }

        public double getArea()
        {
            return radius * radius * Math.PI;
        }

        public void setRadius(double newRadius)
        {
            radius = newRadius;
        }

        // overload
        public override string ToString()
        {
            return String.Format("The Circle Has Radius Of {0} And Color Of {1}", radius, color);
            //return base.ToString();
        }
    }
}
