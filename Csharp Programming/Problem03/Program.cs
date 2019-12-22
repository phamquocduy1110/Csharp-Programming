using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            int A = 0, B = 100;
            int count = 1;
            while (B > A + 1)
            {
                int c = (A + B) / 2;
                Console.Write("Q{0}: Does Your Number Greater Than {1}? ", count, c);
                count++;
                answer = Console.ReadLine();
                if (answer == "Y".ToLower() || answer == "y".ToUpper());
                {
                    A = c + 1;
                }
                if (answer == "N".ToLower() || answer == "n".ToUpper());
                {
                    B = c;

                }
            }
            Console.Write("Q{0}: Is Your Number {1} ", count, A);
            answer = Console.ReadLine();
            if (answer == "Y".ToLower() || answer == "y".ToUpper())
            {
                Console.Write("Your Number Is: " + A);
            }
            else
            {
                Console.Write("Your Number Is: " + B);
            }
        }
    }
}
