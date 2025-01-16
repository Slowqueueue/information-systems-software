using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface IDateOfArrival
    {
        DateTime CalculateDate(int distance, string vehicletype, DateTime dateofdep);
    }
}
