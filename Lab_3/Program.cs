using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {   //Getting input from user
            String Name, Address,number;
            bool success;
            int Num;
            String Choice;
            Console.WriteLine("Plesae provide your information like name and address");
            Name = Console.ReadLine();
            Address = Console.ReadLine();
            do
            {
                Console.WriteLine(" Hi! :{0} and your address is : {1}", Name, Address);

                do
                {
                    Console.WriteLine("Enter an integer between 1 and 100");
                    number = Console.ReadLine();
                    success = int.TryParse(number, out Num);
                    if (Num <0 || !success)
                    {
                        Console.WriteLine("Please enter the valid number!");
                    }
                } while (Num < 0 || !success);
                //processing and Output
                if (Num % 2 != 0)
                {
                    Console.WriteLine("{0} and Odd ", Num);
                }
                else if (Num % 2 == 0 && Num >= 2 && Num <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if (Num % 2 == 0 && Num >= 26 && Num <= 60)
                {
                    Console.WriteLine("Even");
                }
                else if (Num % 2 == 0 && Num > 60)
                {
                    Console.WriteLine("Even");
                }
                else if (Num % 2 != 0 && Num > 60)
                {
                    Console.WriteLine("Odd");
                }
                else { }

                Console.WriteLine("Do you want to continue? Yes or No");
                Choice = Console.ReadLine();

            } while (Choice == "Yes");

        }
    }
}
