using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace OpenableInterface
{


    interface OpenableInterface {
        string OpenSesame() {
            return "";
        }
    }

    class TreasureBox : OpenableInterface
    {
      public string OpenSesame()
        {
            return "Congratulations , Here is your lucky win";
        }
    }
    class Parachute : OpenableInterface
    {
        public string OpenSesame()
        {
            return "Have a thrilling experience flying in air";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the letter found in the paper");
            char ch = char.Parse(Console.ReadLine());
           // OpenableInterface oi;
            if (ch == 'T')
            {
               TreasureBox oi = new TreasureBox();
               Console.WriteLine(oi.OpenSesame());
            }
            else if(ch=='P') {
              Parachute  oi = new Parachute();
                Console.WriteLine(oi.OpenSesame());
            }
        }
    }
}
