using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle.Example
{
        class Circle
        {
            double pi;
            double radius;

            public Circle(double pi, double radius)
            {
                this.pi = pi;
                this.radius = radius;
            }

        public Circle()
        {

        }


            public void AcceptDetails()
            {
                pi = Math.PI;
                radius = 7;
            }

            public double CalculateArea()
            {
                return pi * Math.Pow(radius,2);
            }

            public void DisplayResult()
            {
                Console.WriteLine("Area {0}", CalculateArea());
            }

        }
    }
