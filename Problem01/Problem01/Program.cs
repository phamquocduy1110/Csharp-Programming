using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int keyWord = 1;
            Boolean confirm = true;
            do
            {
                Console.WriteLine("\n=============== Bank Account Functions System ===============");
                Console.WriteLine("Hello Friend, What Can I Do For You: ");
                Console.WriteLine("\nPlease Select A Function: ");
                Console.WriteLine("\n1. Amount To Deposit");
                Console.WriteLine("\n2. Amount To Withdraw");
                Console.WriteLine("\n3. Check For Your Balance");
                Console.WriteLine("\nYour Function Has Been Selected: ");

                Console.Write("\nImport Your Request From Function System: ");
                string answer = Console.ReadLine();
                keyWord = Convert.ToInt32(answer);
                switch (keyWord)
                {
                    // ========================  The Lessons In Semester I ========================
                    case 1:
                        Amount_To_Deposit();
                        break;
                    case 2:
                        Amount_To_Withdraw();
                        break;
                    case 3:
                        Check_For_Your_Balance();
                        break;
                    default:
                        Console.WriteLine("\nThere Was No Your Function Selected ");
                        break;
                }
                Console.Write("\nDo You Want To Continue? (Yes or No)" + "\nPress y To Agree - n To Disagree: ");
                String confirmation = Console.ReadLine();
                if (confirmation.Equals("y") == true)
                {
                    Console.WriteLine("\nImport A Function To Continue: ");
                    confirm = true;
                }
                else
                {
                    Console.WriteLine("\nEnd Processed");
                    confirm = false;
                }

            }
            while (confirm);
        }

        private static void Amount_To_Deposit()
        {
            Account acc = new Account(10000000);

            Console.WriteLine("\nImport Amount You Want To Deposit: ");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            acc.Deposit(a);
        }

        private static void Amount_To_Withdraw()
        {
            Account acc = new Account(10000000);

            Console.WriteLine("\nImport Amount You Want To Withdraw: ");
            string str = Console.ReadLine();
            int a = Convert.ToInt32(str);
            acc.Withdraw(a);
        }

        private static void Check_For_Your_Balance()
        {
            Console.WriteLine("\nYour Total Remaining Balance Is: ")
            Account acc = new Account(10000000);
            acc.Balance();
        }
    }
}
