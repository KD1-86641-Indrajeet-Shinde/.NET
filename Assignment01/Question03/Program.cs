using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                char choice = 'a';

                Console.WriteLine("Enter operation(e, +, -, *, /)");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'e':
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case '+':
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Addition is " + (num1 + num2));

                            break;
                        }
                    case '-':
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Subtraction is " + (num1 - num2));

                            break;
                        }
                    case '*':
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Multiplication is " + (num1 * num2));

                            break;
                        }
                    case '/':
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Division is " + (num1 / num2));

                            break;
                        }
                }
            }
        }
    }
}
