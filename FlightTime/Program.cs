using System;
using System.Globalization;

namespace FlightTime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");


            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            String date = "25-10-1998";
            date = date.Replace('-', '/');
            Console.WriteLine(date);
            DateTime now = DateTime.Now;

           DateTime dob = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int age = now.Year - dob.Year;

            if (now.DayOfYear < dob.DayOfYear) {
                age--;
            }

            Console.WriteLine("age = "+age);

            Console.WriteLine("date:" + dob +"\n Month dob:"+dob.DayOfYear);
            /*
            DateTime d1= Convert.ToDateTime("13:54:10");
            DateTime d3 = Convert.ToDateTime("10:54:10");
            DateTime d2 = DateTime.Now;

            TimeSpan ts = d1.Subtract(d2);

            Console.WriteLine("Here is a time:");
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Duration());
            Console.WriteLine(d1>d2);
            Console.WriteLine(d1 > d3);
            */
        }
    }
}
