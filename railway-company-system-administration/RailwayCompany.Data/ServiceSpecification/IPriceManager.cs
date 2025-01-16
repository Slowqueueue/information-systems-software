using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface IPriceManager
    {
        double CalculatePrice(int distance,double priceFromCategory);
    }
}
