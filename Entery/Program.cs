using System;

namespace Entery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter age(completed years and months)");
            string sage = Console.ReadLine();
            double ag = double.Parse(sage);
            int age = (int)ag;

            Console.WriteLine("Enter gender('M' for Male and 'F' for Female");
            string gen = Console.ReadLine();

            Console.WriteLine("Enter city");
            string city = Console.ReadLine();


            Console.WriteLine("Enter mobile number");
            string mobile = Console.ReadLine();

            Console.WriteLine("Enter pincode");
            string pincode = Console.ReadLine();

            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gen);
            Console.WriteLine("City: "+city);
            Console.WriteLine("Mobile: "+mobile);
            Console.WriteLine("Pincode: "+pincode);

        }



    }
}
