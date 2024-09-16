using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************** My Little Calculator ********************");
            Console.WriteLine("'+'\n'-'\n'*'\n'/'\nPlease choose one of the options above. ");

            for (int i = 0; i < 20; i++)
            {
                string choice = Console.ReadLine();
                string plus = "+";
                string minus = "-";
                string multiply = "*";
                string divide = "/";
                if (choice == plus)
                {
                    Console.WriteLine("You choose the plus.");
                    Console.Write("Enter the 1st number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the 2nd number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("The result is: " + (number1 + number2)+ "\nİf you want to continue calculating please choose one of the options above.\n");
                }
                else if (choice == minus)
                {
                    Console.WriteLine("You choose the minus.");
                    Console.Write("Enter the 1st number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the 2nd number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("The result is: " + (number1 - number2) + "\nİf you want to continue calculating please choose one of the options above.\n");
                }
                else if (choice == multiply)
                {
                    Console.WriteLine("You choose the multiply.");
                    Console.Write("Enter the 1st number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the 2nd number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("The result is: " + (number1 * number2) + "\nİf you want to continue calculating please choose one of the options above.\n");
                }
                else if (choice == divide)
                {
                    Console.WriteLine("You choose the divide.");
                    Console.Write("Enter the 1st number: ");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the 2nd number: ");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("The result is: " + (number1 / number2) + "\nİf you want to continue calculating please choose one of the options above.\n");
                }
                else
                    Console.WriteLine("Please choose one of the options above!");
            }
            
            Console.Read();
        }
    }
}
