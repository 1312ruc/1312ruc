using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2._77
{
    class Task7
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("a: ");
                int a = int.Parse(Console.ReadLine());
                Console.Write("b :");
                int b = int.Parse(Console.ReadLine());
                Console.Write("c: ");
                int c = int.Parse(Console.ReadLine());

                if ((a + c < b) || (a + b < c) || (b + c < a))
                {
                    Console.WriteLine("you`re stupid!!!!!!!!!!");
                }
                else if ((a == b) && (a == c) && (b == c))
                {
                    Console.WriteLine("Triugulnikut e ravnostranen");
                }
                else if ((a == b) || (b == c) || (a == c))
                {
                    Console.WriteLine("Triugulnikut e ravnobedren");
                }
                else if ((a != b) && (b != c) && (a != c))
                {
                    Console.WriteLine("Triugulnika e raznostranen");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("             $$$$$$$");
                Console.WriteLine("           $$$$$$$$$$");
                Console.WriteLine("          $$$$$$$$$$$");
                Console.WriteLine("          $$$$$$$$$$");
                Console.WriteLine("         $$$$$$$$$$");
                Console.WriteLine("       $$$$$$$$$$");
                Console.WriteLine("         $$$$$$$$$$");
                Console.WriteLine("         $$$$$$$$$$$$$");
                Console.WriteLine("         $$$$$$$$$$$$$");
                Console.WriteLine("         $$$  $$$$$$$        $$$$$$");
                Console.WriteLine("       $$     $$$$$$     $$$$$$$$$$$");
                Console.WriteLine("      $$       $$$$$  $$$$$$$    $$$$");
                Console.WriteLine("     $$        $$$$$$$$$$$$         $$$$");
                Console.WriteLine("    $$        $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                Console.WriteLine();
                
                 
            
                    
            }
            
        }
    }
}
