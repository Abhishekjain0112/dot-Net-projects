using System;
using System.IO;

namespace FileManager
{
    class Program
    {
        static void Main(string[] args)
        {



            foreach (string line in File.ReadLines(@"sample1.txt"))
            {
                // Printing the file contents 
                File.AppendAllText("sample2.txt", line);
                Console.WriteLine(line);

            }
            Console.WriteLine("From sample1.txt");
            foreach (string line in File.ReadLines(@"sample1.txt"))
            {
                // Printing the file contents 
                Console.WriteLine(line);
            }
            Console.WriteLine("From sample2.txt");
            foreach (string line in File.ReadLines(@"sample2.txt"))
            {
                // Printing the file contents 
                Console.WriteLine(line);
            }







            /*  Console.WriteLine("Enter the  Sentence");
             string newContent = Console.ReadLine();
              var path = Path.Combine(Directory.GetCurrentDirectory(), "\\sentences.txt");
              while (!String.IsNullOrEmpty(newContent))
              {
                  File.AppendAllText(path, newContent + Environment.NewLine);
                  newContent = Console.ReadLine();
              }
              foreach (string line in File.ReadLines(@"sentences.txt"))
              {
                  // Printing the file contents 
                  Console.WriteLine(line);
              }
             */
        }
    }
}
