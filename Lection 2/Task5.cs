using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework2._5
{
    class Task5
    {
        static void Main(string[] args)
        {
            Console.Write("Name : ");
            string name = Console.ReadLine();
            Console.Write("Your ID : ");
            string iD = Console.ReadLine();
            Console.Write("Phone numbers : ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Hello \"{0}\" your ID is  \"{1}\" and your phone number is \"{2}\"",name,iD,phoneNumber);
            Console.WriteLine();
        }
    }
}
