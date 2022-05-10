using System;
using Tester;

namespace FSPG1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Test.Run(2);
            Console.ReadKey();
            Console.WriteLine("Enter a number! " );
            Console.ReadLine();
        }
    }
}
