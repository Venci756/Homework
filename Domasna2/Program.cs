using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domasna2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter the first number.");
            string fristInput = Console.ReadLine();
            bool firstNumber = int.TryParse(fristInput, out int first);


            Console.WriteLine("Please enter the second number");
            string secondInput = Console.ReadLine();
            bool secondNumber = int.TryParse(secondInput, out int second);

            if (!firstNumber&&!secondNumber)
            {
               if (!firstNumber)
                {
                    Console.WriteLine($"You entered {fristInput} which is not a valid number.");
                }
               else if (!secondNumber)
                {
                    Console.WriteLine($"You entered {secondInput} which is not a valid number.");
                }
               


            }
            else
            {
                Console.WriteLine("--------------------------------");
                if (first > second)
                {
                    Console.WriteLine($"Number {first} is bigger than {second}.");

                }
                else if (second > first)
                {
                    Console.WriteLine($"Number {second} is bigger than {first}.");
                }
                else
                {
                    Console.WriteLine("The numbers are equal");
                };

                if (!firstNumber)
                {
                    Console.WriteLine("Invalid number.");
                }
                else if (first % 2 == 0)
                {
                    Console.Write($"Number {first} is even.");
                }
                else
                {
                    Console.Write($"Number {first} is odd.");
                }

                if (!secondNumber)
                {
                    Console.WriteLine("Invalid number.");
                }
                else if (second % 2 == 0)
                {
                    Console.Write($"Number {second} is even.");
                }
                else
                {
                    Console.Write($"Number {second} is odd.");
                }
            }
            

            //if (!secondNumber)
            //{
            //    Console.WriteLine($"You entered {secondInput} which is not a valid number.");
                
            //}
            


            



        }
    }
    
}
