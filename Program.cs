// See https://aka.ms/new-console-template for more information
using System;

namespace Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string x = "1747";
            var y = int.Parse(x);

            double z = y / 100;

            var a = z % 10;
            var b = x[1];
            

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(x[1]);

            Console.WriteLine(a == 7 && x[1] == 7 ? "You are correct": "You are wrong");
            if(a==7 && b == 7)
            {
                Console.WriteLine("You are Correct");
            }
            else
            {
                Console.WriteLine("You are wrong");
            }


        }
    }
}


