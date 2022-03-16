using System;
using Circle.Example;

namespace Circle.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.AcceptDetails();
            circle.CalculateArea();
            circle.DisplayResult();
            Console.ReadLine();
        }
    }
}
