using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace BallsBowled        //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        static void Main(string[] args)
        {
            //Implement code here  
            PlayerBO p = new PlayerBO();
            Console.WriteLine("Enter the number of overs");

            int overs = int.Parse(Console.ReadLine());

            p.AddOversDetails(overs);
            Console.WriteLine(p.GetNoOfBallsBowled());



        }
    }

    public class PlayerBO      //DO NOT change the class name
    {
        public List<int> PlayerList { get; set; } = new List<int>();

        public void AddOversDetails(int oversBowled)       //DO NOT change the method signature
        {
            //Implement code here
            PlayerList.Add(oversBowled);
        }

        public int GetNoOfBallsBowled()              //DO NOT change the method signature
        {
            //Implement code here
            foreach (int i in PlayerList) {
                return i * 6;
            }
            return 0;
        }


    }
}