using PolimorfismoExercicio.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace PolimorfismoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Quantidade de Produtos:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} : ");
                Console.Write("Common, Used or Imported ?" );
                char c = char.Parse( Console.ReadLine());

                Console.Write("Name:    ");
                string name = Console.ReadLine();
                Console.Write("Price:    ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if ( c == 'i')
                {
                    Console.Write("Customs fee:    ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customFee));
                }
                else if (c == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else
                {
                    Console.Write("Manufacture date:    ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactureDate));
                }
            }


            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product emp in list)
            {
                Console.WriteLine(emp.PriceTag());
            }
        }
    }
}
