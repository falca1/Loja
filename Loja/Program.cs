using Loja.Entities;
using System;
using System.Globalization;

namespace Loja 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Product> products = new List<Product>();

            Console.Write("Enter the number os products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Product #{i} data: ");

                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch =='i' || ch == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if (ch == 'u' || ch == 'U')
                {
                    Console.Write("Manufacture date: ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, date));
                } else if (ch=='c' || ch=='C')
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS: ");

            foreach (Product product in products)
            {
                Console.WriteLine(product.priceTag());
                
            }

        }
    }
}