using MetodoAbstrato.Entities;
using MetodoAbstrato.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace MetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de Figuras :D");
            int n = int.Parse(Console.ReadLine());

            List<Shape> list = new List<Shape>();

            for(int i =1; i<=n; i++)
            {
                Console.WriteLine($"Shape #{i} data:  ");
                Console.Write("Retangle or Circle?    " );
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Color (Black/Blue/Red");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if(ch == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Rectangle(width, height, color));
                }

                else if (ch == 'c')
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    

                    list.Add(new Circle(radius, color));
                }
                else
                {
                    Console.WriteLine("ATENÇÃO NAO EXISTE ESSA FIGURA");
                }

                Console.WriteLine("Shape Areas:");

                foreach (Shape shape in list)
                {
                    Console.WriteLine(shape.Area());
                }
            }
        }
    }
}
