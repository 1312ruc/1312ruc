using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zad7
{
    class Task7
    {
        static void Main(string[] args)
        {
             Console.Write("Въведете а =");
             double a = Double.Parse(Console.ReadLine());
             Console.Write("Въведете b =");
             double b = Double.Parse(Console.ReadLine());
             Console.Write("Въведете c =");
             double c = Double.Parse(Console.ReadLine());
             double d = b * b - 4 * a * c;
             Console.WriteLine("Дискриминантата е: " + d.ToString());

                if (d <0)
                {
                    Console.WriteLine("Дискриминантата е отрицателна затова уравнението няма решение");
                }
                else if (d == 0)
                    {
                        Console.WriteLine("Дискриминантата е равна на нула затова има само едно решение: x=" + ((-b) / (4 * a)).ToString());
                    }
                else
                    {
                        Console.WriteLine("x1=" + ((-b + Math.Sqrt(d)) / (4 * a)).ToString());
                        Console.WriteLine("x2=" + ((-b - Math.Sqrt(d)) / (4 * a)).ToString());
                    }
        }
    }
}
