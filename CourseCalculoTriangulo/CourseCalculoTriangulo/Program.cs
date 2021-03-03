using System;
using System.Globalization;

namespace CourseCalculoTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double areaX, areaY, p;
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do Triangulo X: ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do Triangulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            areaX = x.Area();
            areaY = y.Area();

            Console.WriteLine("Area X:  " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Area Y:  " + areaY.ToString("F4", CultureInfo.InvariantCulture));


            if (areaX > areaY)
            {
                Console.WriteLine("Maior Area X");
            }
            else
            {
                Console.WriteLine("Maior Area Y");
            }

          
        }
    }
}
