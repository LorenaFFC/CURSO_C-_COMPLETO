using ExcecoesPersonalizadas.Entities;
using ExcecoesPersonalizadas.Entities.Exceptions;
using System;

namespace ExcecoesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number:  ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy) :  ");
                DateTime chekIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy) :  ");
                DateTime chekout = DateTime.Parse(Console.ReadLine());

                Reservation reservation = new Reservation(roomNumber, chekIn, chekout);

                Console.WriteLine("Data de saida menor do que data de entrada");

                Console.WriteLine();
                Console.WriteLine("Digite os dados da Atualização da reserva :D ");
                Console.Write("Check-in date (dd/MM/yyyy) :  ");
                chekIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy) :  ");
                chekout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDate(chekIn, chekout);
                Console.WriteLine("Reservation:  " + reservation);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in Reservation:"  +  e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("FORMAT ERROR:" + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR:   " + e.Message);
            }

        }
    }
}
