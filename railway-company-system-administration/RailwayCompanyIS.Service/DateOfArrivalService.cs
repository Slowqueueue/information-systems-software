using RailwayCompanyIS.Data.ServiceSpecification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Service
{
    public class DateOfArrivalService : IDateOfArrival
    {
        public DateTime CalculateDate(int distance, string vehicletype, DateTime dateofdep)
        {
            DateTime dateofarr = DateTime.Now;
            switch (vehicletype)
            {
                case "Обычный":
                    dateofarr = dateofdep.AddMinutes(Math.Truncate((double)distance / 40 * 60));
                    break;
                case "Скорый":
                    dateofarr = dateofdep.AddMinutes(Math.Truncate((double)distance / 90 * 60));
                    break;
                case "Скоростной":
                    dateofarr = dateofdep.AddMinutes(Math.Truncate((double)distance / 140 * 60));
                    break;
            }
            return dateofarr;
        }
    }
}
