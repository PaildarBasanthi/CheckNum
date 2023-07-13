using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssign5_1App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int a=int.Parse(Console.ReadLine());
            if (a > 0) {
                Console.WriteLine("number is positive");

            }
            else if(a < 0)
            {
                Console.WriteLine("number is negitive");
            }
            else if (a == 0) {
                Console.WriteLine("number is equal to zero");

            }
            else {
                Console.WriteLine("invalid");
            }
            //check number is even or odd
            string evenOrOdd = (a % 2 == 0) ? "even" : "odd";
            Console.WriteLine("the number is " + evenOrOdd + ".");
        }
    }
}
