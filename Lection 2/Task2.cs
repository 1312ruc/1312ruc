using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2._2
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("h = ");
            float h = float.Parse(Console.ReadLine());

            float area = (a + b) / 2 * h;
            Console.WriteLine("area ={0} ",area);

        }
    }
}
