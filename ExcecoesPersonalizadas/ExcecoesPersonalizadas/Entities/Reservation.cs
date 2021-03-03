using ExcecoesPersonalizadas.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcecoesPersonalizadas.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime ChekIn { get; set; }
        public DateTime ChekOut { get; set; }

        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime chekIn, DateTime chekout)
        {
            if (chekout <= chekIn)
            {
                throw new DomainException("check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            ChekIn = chekIn;
            ChekOut = chekout;
        }


        public int Duration()
        {
            TimeSpan duration = ChekOut.Subtract(ChekIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDate(DateTime checkIn,DateTime checkOut)
        {

            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
               throw new DomainException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("check-out date must be after check-in date");
            }

            ChekIn = checkIn;
            ChekOut = checkOut;
            
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in"
                + ChekIn.ToString("dd/MM/yyyy")
                + ", check-out"
                + ChekOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "  nigths";
        }
    }
}
