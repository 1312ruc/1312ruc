using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2._3
{
    class Task3
    {
        static void Main(string[] args)
        {
            Console.Write( "a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            if ((a + c < b) || (a + b < c) || (b + c < a))
            {
                Console.WriteLine("You`re StupidDDD");
            }
            else
            {
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine(area);
            }
        }
    }
}
