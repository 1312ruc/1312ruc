using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter number ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Negative");
                }

                else if (num == 0)
                {

                    Console.Write("Zero ");
                    Console.WriteLine();
                }


                else if (num > 0)
                {
                    Console.Write("Positive ");
                    Console.WriteLine();
                }

            }
            catch (Exception)
            {
                Console.WriteLine("you`re stupid ");
                Console.WriteLine();
                
                
            }
                          

        }
    }
}