using System;
using System.Collections.Generic;

namespace Youtube // a namespace - used for organization
{
    class Program // a class - has members (such as a method)
    {
        static void Main(string[] args) // a method - contain a block of code
        {
            Program myProgram = new Program();
            myProgram.Print();

           // int y; // Decoration
           // y = 5; // initialization

            int a = -5;
            uint b = 5;
            char c = 'C';
            float d = 5.5f;
            double e = 5.5;
            decimal f = 5.5M;
            bool g = true;
            string h = "Hello";

            int i = (int)5.999;
            double j = 5;

            float k = 5.5f;
            double l = 5.5;
            decimal m = 10.5M;

            double n = Math.Pow(99999, 888888);
            double o = double.PositiveInfinity;

            Console.WriteLine(n);
        
            int y = -5;
            int z = y;
            
            Console.WriteLine(y);
            Console.WriteLine(z);

            z = 10;

            Console.WriteLine(y);
            Console.WriteLine(z);

            //Using Math Object
            //using math round directly will round it off to the next even number 
            //To round off to accurately, we use mid point rounding away from zero
            double u = -50.5;
            Console.WriteLine(Math.Round(u,0,MidpointRounding.AwayFromZero));
            //if we want to easily round down or up we can use floor or ceiling.
            //Floor to round down
            Console.WriteLine(Math.Floor(u));
            // ceiling to round up
            Console.WriteLine(Math.Ceiling(u));
            //To ignore the decimal point which is also the same as round down, we use truncate
            Console.WriteLine(Math.Truncate(u));

            //We can use the Min and Max function of math.
            // The Min gives us the samllest value when comparing two variables
            double v = 80;
            Console.WriteLine(Math.Min(v, u));
            // The Max gives us the highest number
            Console.WriteLine(Math.Max(v, u));
            //we have the Abs which return the positive values of what is inputted
            Console.WriteLine(Math.Abs(u));
            //we have the sign function which indicate if the number is positive or negative
            Console.WriteLine(Math.Sign(u));
            Console.WriteLine(Math.Sign(v));

            //Working with the character data type
            char letter = 'a';
            int number = 'a';

            //We can use char compared with the Ascii table. Char is a 16bit while int is 8bit

            //Using the string data type
            string name = "caleb";
            //To concatenate this, i can use the +=
            name += "Curry";
            Console.WriteLine(name);

            //we can use the $ sign to add words or information to the string type 
            //You can convert a character to string 
            char[] characters = { 'h', 'e', 'l', 'l', 'o' };
            string greeting = new string(characters);
            Console.WriteLine(greeting);

            string message = $"Hello my name is {name}, and I like to say {greeting}";
            Console.WriteLine(message);

            // To get the properties of a string, lets use length
            Console.WriteLine(name.Length);

            //To get the methods of a string lets use compare to
            Console.WriteLine(name.CompareTo("Daleb"));
            //Lets use method of IndexOf. You will have another opportunity to an arguments
            Console.WriteLine(name.IndexOf("al"));
            //we can pass an argument and say we want to start from the second index
            Console.WriteLine(name.IndexOf("al", 2));
            //You can remove exceptional characters
            Console.WriteLine(name.Remove(2));
            //You can use trim to remove spaces between the characters
            Console.WriteLine(name.Trim());




            






            int[] s = { -20 };
            int[] t = s;

            Console.WriteLine(s[0]);
            Console.WriteLine(t[0]);

            t[0] = 30;

            Console.WriteLine(s[0]);
            Console.WriteLine(t[0]);

            Test(s[0]);
            Console.WriteLine(s[0]);
      
}
        static void Test(int s)
        {
            s = 100;
        }

        void Print()
        {
            string x = Console.ReadLine();
            Console.WriteLine(x);
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine(); //fully qualified name
            Console.WriteLine("Hello World!"); // its a statement
            Console.WriteLine("Best Friend"); //  am testing a statement
            //Console.WriteLine(y);
            //Console.WriteLine(z);
        }
    }
    
}
//you create a method
//you invoke a method