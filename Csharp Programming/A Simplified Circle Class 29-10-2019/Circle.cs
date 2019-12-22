using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Simplified_Circle_Class_29_10_2019
{
    class Circle
    {
        private double Radius = 1.0;

        public Circle()
        {
            
        }

        public Circle(double r)
        {

        }

        public double getRadius()
        {
            return this.Radius;
        }

        public void setRadius(double newRadius)
        {
            Radius = newRadius;
        }

        public double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double getCircumference()
        {
            return Math.PI * Radius;
        }

        public String toString()
        {
            return base.ToString();
        }
    }
}
