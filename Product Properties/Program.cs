using System;

namespace Product_Properties
{


    public class Product
    {

        private int productId;

        private String productName;

        private double price;

       public int ProductId { get { return productId; } set { productId = value; } }

      public String ProductName { get { return productName; } set { productName = value; } }

        public double Price { 
            get {
                if (price < 0)
                {
                    return 0;
                }
                else { return price; }
            }set { price = value; } 
        }

        public void Display() {
            Console.WriteLine("Product ID: "+ProductId);
            Console.WriteLine("Product Name: "+ProductName);
            Console.WriteLine("Product Price: " + Price);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product id");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter product name ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter product id");
            double price = double.Parse(Console.ReadLine());

            Product p = new Product();
            p.ProductId = id;
            p.ProductName = name;
            p.Price = price;

            p.Display();
        }
    }




}
