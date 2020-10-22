using System;

namespace boolean
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the value for x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value for y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("The result of whether x is less than y  is " + (x < y));
        }
    }
}
