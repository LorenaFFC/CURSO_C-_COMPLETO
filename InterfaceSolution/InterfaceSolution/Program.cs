using InterfaceSolution.Entities;
using InterfaceSolution.Services;
using System;
using System.Globalization;

namespace InterfaceSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.WriteLine("Car Model:  ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm) :   ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.WriteLine("Return  (dd/MM/yyyy hh:mm) :   ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per Hour:" );
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per Day:");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrasiTaxService());

            rentalService.ProcessInvoice(carRental);
            Console.WriteLine(carRental);

            Console.WriteLine("Invoice" );
            Console.WriteLine(carRental.Invoice);

        }
    }
}
