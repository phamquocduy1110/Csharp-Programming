using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_On_Composition_31_10_2019_part_II
{
    class MyPoint
    {
        private int X, Y;

        public MyPoint()
        {
            this.X = this.Y = 0;
        }

        public MyPoint(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public int GetX()
        {
            return X;
        }

        public void SetX(int x)
        {
            this.X = x;
        }

        public int GetY()
        {
            return Y;
        }

        public void SetY(int y)
        {
            this.Y = y;
        }

        public int[] GetXY()
        {
            // Way: 1
            //int[] result = new int[2];
            //result[0] = X;
            //result[1] = Y;
            //return result;

            //Way: 2
            return new int[] { this.X, this.Y };
        }

        public void SetXY(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return String.Format("({0}, {1}", this.X, this.Y);
        }

        public double Distance(int x, int y)
        {
            return Math.Sqrt(Math.Pow(this.X - x, 2) + Math.Pow(this.Y - y, 2));
        }

        public double Distance(MyPoint point)
        {
            return Distance(point.GetX(), point.GetY());
        }

        public double Distance()
        {
            return Distance(0, 0);
        }
    }
}
