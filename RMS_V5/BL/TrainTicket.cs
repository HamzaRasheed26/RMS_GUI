using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMS_V5.BL
{
    public class TrainTicket : Booking
    {
        private int quantity;  // for quantity of tickets

        public TrainTicket(string trainName, string from, string to, int quantity, float price, int booking_no, float day, float month, float year) : base(trainName, from, to, price, booking_no, day, month, year)
        {
            this.quantity = quantity;
        }

        public TrainTicket(string trainName, string from, string to, int quantity, float price, int booking_no, float day, float month, float year, float date) : base(trainName, from, to, price, booking_no, day, month, year, date)
        {
            this.quantity = quantity;
        }

        public int Quantity { get => quantity; set => quantity = value; }

    }
}

