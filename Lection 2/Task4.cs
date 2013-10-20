using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2._4
{
    class Task4
    {
        static void Main(string[] args)
        {
            Console.Write("num =  ");
            int a = int.Parse(Console.ReadLine());
            int b = a << 3;
            Console.WriteLine("{0}*8 = {1}",a,b);
        }
    }
}
