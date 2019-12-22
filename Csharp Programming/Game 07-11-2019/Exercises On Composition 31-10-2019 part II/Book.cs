using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_On_Composition_31_10_2019_part_II
{
    class Book
    {
        private string Name;
        private Author[] Authors;
        private double Price;
        private int Qty = 0;
        private string v1;
        private Author ahTeck;
        private double v2;
        private int v3;

        //Way: 3
        public Book(string name, Author[] authors, double price, int qty = 0)
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Qty = qty;
        }

        public Book(string v1, Author ahTeck, double v2, int v3)
        {
            this.v1 = v1;
            this.ahTeck = ahTeck;
            this.v2 = v2;
            this.v3 = v3;
        }

        //Way: 2
        //public Book(string name, Author author, double price, int qty) : this(name, author, price)
        //{
        //this.Qty = qty;
        //}

        public String GetName()
        {
            return this.Name;
        }

        public Author[] GetAuthors()
        {
            return this.Authors;
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public void SetPrice(double price)
        {
            this.Price = price;
        }

        public void SetQty(int qty)
        {
            this.Qty = qty;
        }

        public int GetQty()
        {
            return this.Qty;
        }

        public override string ToString()
        {
            string[] strAuthors = new string[this.Authors.Length];
            for (int i = 0; i < this.Authors.Length; i++)
            {
                strAuthors[i] = this.Authors[i].ToString();
            }
            return String.Format("Book[name={0},authors={{{1}}},price={2},qty={3}]", this.Name, String.Join(",", strAuthors), this.Price, this.Qty);
        }

        //public string GetAuthorName()
        //{
        //return this.Authors.GetName();
        //}

        //public string GetAuthorEmail()
        // {
        //return this.Authors.GetEmail();
        //}

        //public string GetAuthorGender()
        //{
        //return this.Authors.GetGender();
        //}

        public string GetAuthorNames()
        {
            string[] strAuthorNames = new string[this.Authors.Length];
            for(int i = 0; i < this.Authors.Length; i++)
            {
                strAuthorNames[i] = this.Authors[i].GetName();
            }
            return String.Join(",", strAuthorNames);
        }
    }
}
