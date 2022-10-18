using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 345;

            int sot = c / 100;
            int des = c / 10 % 10;
            int ed = c % 10;

            Console.WriteLine($"{sot},{des},{ed}");









        }
    }
}
