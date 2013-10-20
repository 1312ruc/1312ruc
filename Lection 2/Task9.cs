using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2._88
{
    class Task9
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Въведете цифра : ");
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 0: Console.WriteLine("Нула"); break;
                    case 1: Console.WriteLine("Едно"); break;
                    case 2: Console.WriteLine("Две"); break;
                    case 3: Console.WriteLine("Три"); break;
                    case 4: Console.WriteLine("Четири"); break;
                    case 5: Console.WriteLine("Пет"); break;
                    case 6: Console.WriteLine("Шест"); break;
                    case 7: Console.WriteLine("Седем"); break;
                    case 8: Console.WriteLine("Осем"); break;
                    case 9: Console.WriteLine("Девет"); break;
                }

            }
            catch (Exception)
            {
                Console.WriteLine("ИдИоОоОот");
                
                
            }
            

       
        }
    }
}

