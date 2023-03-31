using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List
{
    class Switch_Statement
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("Enter a one digit number");
            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                default:
                    Console.WriteLine("Number entered is not a one digit number");
                    break;
            }
        }
    }
}