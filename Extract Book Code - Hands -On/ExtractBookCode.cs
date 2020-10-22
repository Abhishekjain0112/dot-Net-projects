using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBookCode      //Do not change the namespace name
{
    public class Program      //Do not change the class name
    {
        public static void Main(String[] arg)         //Do not change the method signature
        {
            //Implement code here
            String input,bookId,dept,pub,page,blf;
            char bfc;
            int departmentCode,publicationYear,noPages;
            Console.WriteLine("Enter the book code of length 18");
            input=Console.ReadLine();
            if(!(input.Length!=18))
            {
            dept=input.Substring(0,3);
            pub=input.Substring(3,4);
            page=input.Substring(7,5);
            bfc=char.Parse(input.Substring(12,1));
            blf=input.Substring(13,5);
            //Console.WriteLine("dept {0} \n pub {1} \n pages{2} \n bid {3}{4}",dept,pub,page,bfc,blf);
            //Console.WriteLine("{0}  {1}  {2}   {3} {4} {5}",
            //!(input.Length!=18),dept.All(Char.IsDigit) , pub.All(Char.IsDigit) ,
            //page.All(Char.IsDigit),Char.IsLetter(bfc),blf.All(Char.IsDigit));
              departmentCode=int.Parse(dept);
                if(departmentCode>=101 && departmentCode<=103)
                    Console.WriteLine("Department Code        : {0}",departmentCode);
                else
                    Console.WriteLine("Invalid Department Code");
                publicationYear=int.Parse(pub);
                if(publicationYear>=1900 && publicationYear<=2020)
                    Console.WriteLine("Year of Publication     : {0}",publicationYear);
                else
                    Console.WriteLine("Invalid Year");
                noPages=int.Parse(page);
                if(noPages>=00001 && noPages<=99999)
                    Console.WriteLine("Number of Pages        : {0,0:D5}",noPages);
                else
                    Console.WriteLine("Invalid Page Numbers");
                bookId=bfc+blf;
                if(Char.IsLetter(bfc) && blf.All(Char.IsDigit))
                    Console.WriteLine("Book ID               : {0}",bookId);
                else
                    Console.WriteLine("Invalid Book ID");
            
            }
            else
                Console.WriteLine("Invalid Book Code");
        }
    }
}