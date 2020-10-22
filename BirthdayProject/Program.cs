using System;
using System.Security.Cryptography.X509Certificates;

namespace BirthdayProject
{
    public class BirthdayProject      //DO NOT change the class name
    {
        //implement code here
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Person person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Dob = dob;
            person.DisplayDetails();
            Console.Read();





        }
    }

    public class Person
    {


        private string firstName;
        private string lastName;
        private DateTime dob;


        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public DateTime Dob { get { return dob; } set { dob = value; } }
        public string Adult { get;set;}
        

        public int GetAge(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;

            return age;

        }

        public void DisplayDetails()
        {
            Console.WriteLine("First Name: " + this.firstName);
            Console.WriteLine("Last Name: " + this.lastName);
            Console.WriteLine("Last Name: " + GetAge(this.dob));
            int age = GetAge(this.dob);
            if (age < 18)
                Adult = "Child";
            else
                Adult = "Adult";
            Console.WriteLine(Adult);

        }

    }



}
