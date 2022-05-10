using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            string age = "";

            //Test 1
            Console.WriteLine("Hello Full Sail!");

            //Test 2
            Console.Write("What is your name? \n");

            //Test 3
            name = Console.ReadLine();

            //Test 4
            Console.Write("What is your age? \n");

            //Test 5
            age = Console.ReadLine();

            //Test 6
            Console.WriteLine("Hey! " + name + " Congrats on being " + age + " years young! ");
        }
    }
}
