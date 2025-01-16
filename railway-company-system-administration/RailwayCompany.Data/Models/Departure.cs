using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.Models
{
    public class Departure
    {
        public int Id { get; set; }
        public virtual City CityFrom { get; set; }
        public virtual City CityTo { get; set; }
        public virtual Carrier Carrier { get; set; }
        public virtual PaymentCategory PaymentCategory { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Distance Distance { get; set; }
        public int NumberOfSeats { get; set; }
        public double PriceOfCard { get; set; }
        public virtual DateTime DateOfDeparture { get; set; }
        public virtual DateTime DateOfArrival { get; set; }
    }
}
