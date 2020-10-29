using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
using System.Configuration;
using System.Text.RegularExpressions;

namespace BillAutomation         //DO NOT change the namespace name

{
    public class Program        //DO NOT change the class name
    {
        static void Main(string[] args)  //DO NOT change the 'Main' method signature
        {
            ElectricityBill elec = null;
            Console.WriteLine("Enter Number of Bills To Be Added :");
            int count = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < count; i++)
            {
                //elec = new ElectricityBill("EB10154", "David", 250, 225);
                Console.WriteLine("Enter Consumer Number:");
                string customernumber = Console.ReadLine();
                Match match = Regex.Match(customernumber, @"EB[0-9]5");
                bool val = match.Success;
                try
                {
                    val = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Consumer Number");
                }
                Console.WriteLine("Enter Consumer Name:");
                string customername = Console.ReadLine();
                Console.WriteLine("Enter Units Consumed:");
                int units = int.Parse(Console.ReadLine());
                elec.ConsumerName = customername;
                elec.ConsumerNumber = customernumber;
                elec.UnitsConsumed = units;
            }
            ElectricityBoard eb = new ElectricityBoard();
            eb.CalculateBill(elec);
            eb.AddBill(elec);
            //  eb.Generate_N_BillDetails(elec);
            Console.WriteLine("added");
        }
    }

    public class BillValidator
    {      //DO NOT change the class name
        public String ValidateUnitsConsumed(int UnitsConsumed)      //DO NOT change the method signature
        {
            //Implement code here
            return "Given units is invalid";
        }
    }
}