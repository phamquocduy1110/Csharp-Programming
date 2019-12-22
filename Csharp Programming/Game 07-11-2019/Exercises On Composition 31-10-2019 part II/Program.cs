using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_On_Composition_31_10_2019_part_II
{
    class Program
    {
        static void Main(string[] args)
        {
            Author ahTeck = new Author("Tan Ah Teck", "ahteck@nowhere.com", 'm'); // Test the constructor

            //------------------------------------------ The Author Classes ------------------------------------------

            Console.WriteLine(ahTeck);  // Test toString()
            ahTeck.SetEmail("paulTan@nowhere.com");  // Test setter
            Console.WriteLine("name is: " + ahTeck.GetName());     // Test getter
            Console.WriteLine("eamil is: " + ahTeck.GetEmail());   // Test getter
            Console.WriteLine("gender is: " + ahTeck.GetGender()); // Test gExerciseOOP_MyPolynomial.pngetter

            //------------------------------------------ The Book Classes ------------------------------------------
            
            // Construct an author instance
            Console.WriteLine(ahTeck);  // Author's toString()
            Book dummyBook = new Book("\nJava for dummy", ahTeck, 19.95, 99);  // Test Book's Constructor
            Console.WriteLine(dummyBook);  // Test Book's toString()

            // Test Getters and Setters
            dummyBook.SetPrice(29.95);
            dummyBook.SetQty(28);
            Console.WriteLine("name is: " + dummyBook.GetName());
            Console.WriteLine("price is: " + dummyBook.GetPrice());
            Console.WriteLine("qty is: " + dummyBook.GetQty());
            Console.WriteLine("Author is: " + dummyBook.GetAuthors());  // Author's toString()
            Console.WriteLine("Author's name is: " + dummyBook.GetAuthors().GetName());
            Console.WriteLine("Author's email is: " + dummyBook.GetAuthors().GetEmail());

            // Use an anonymous instance of Author to construct a Book instance
            Book anotherBook = new Book("more Java",
                  new Author[]("Paul Tan", "paul@somewhere.com", 'm'), 29.95);
            Console.WriteLine(anotherBook);  // toString()


            //------------------------------------------ Book and Author Classes Again - An Array of Objects as an Instance Variable ------------------------------------------

            Author[] authors = new Author[2];
            authors[0] = new Author("Tan Ah Teck", "AhTeck@somewhere.com", 'm');
            authors[1] = new Author("Paul Tan", "Paul@nowhere.com", 'm');

            // Declare and allocate a Book instance
            Book javaDummy = new Book("Java for Dummy", authors, 19.99, 99);
            Console.WriteLine(javaDummy);  // toString()
        }
    }
}
