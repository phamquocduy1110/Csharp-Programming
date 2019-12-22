using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Model();
            var dishes = db.Breakfasts.ToArray();
            Console.WriteLine("All Dishes Having Here: " + dishes.Length);
            for(int i = 0; i < dishes.Length; i++)
            {
                Console.WriteLine("Món {0} giá tiền là: {1}.", dishes[i].Name, dishes[i].Price);
            }

            var newDish = new Breakfast();
            newDish.Name = "Cơm vịt";
            newDish.Price = 30000;
            db.Breakfasts.Add(newDish);
            db.SaveChanges();

            db.Dispose();
            
            //foreach(Breakfast dish in dishes)
            //{
                //Console.WriteLine("\t\n" + " " + dish.id + " " + dish.Name + " " + dish.Price);
            //}

            //foreach(Breakfast dish in dishes)
            //{

            //}

            //foreach(Breakfast dish in dishes)
            //{
                //for( i = 0; i < dishes.Length; i++)
                //{
                    //for(j = i + 1; dishes.Length; i++)
                    //{
                        //Consoel
                    //}
                //}
            //}
        }
    }
}
