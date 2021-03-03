using JobComposition.Entities;
using JobComposition.Entities.Enums;
using System;
using System.Globalization;

namespace JobComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Departamento: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base Salary:  ");
            double basaSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, basaSalary, dept);

            Console.WriteLine("Quantos Contratos???"  );
            int n = int.Parse(Console.ReadLine());


            for (int i =1; i<=n; i++)
            {
                Console.WriteLine($"Digite os dados do contrato {i}:   ");
                Console.WriteLine("Digite a Data - DD/MM/YYYY");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Digite o valor por Hora ");
                double valuePerHour  = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("Digite a Duração ");
                int hour = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hour);
                worker.AddContract(contract);

            }

            Console.WriteLine("Diite o mes e ano  mm/yyyy " );
            string meseano = Console.ReadLine();
            int month = int.Parse(meseano.Substring(0, 2));
            int year = int.Parse(meseano.Substring(3));

            Console.WriteLine("Name: " + worker.Nome);
            Console.WriteLine("Departamento : " + worker.Department.Name);
            Console.WriteLine("Income for : " + meseano + " : " + worker.Income(year, month) );
        }
    }
}
