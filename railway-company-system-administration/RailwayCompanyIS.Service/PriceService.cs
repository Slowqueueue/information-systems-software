using RailwayCompanyIS.Data.ServiceSpecification;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Service
{
    public class PriceService : IPriceManager
    {
        public double CalculatePrice(int distance, double priceFromCategory)
        {
            if(distance < 500)
            {
                return distance * 0.5 + priceFromCategory;
            }else if(distance < 1000)
            {
                return distance * 1 + priceFromCategory;
            }else if(distance < 1500)
            {
                return distance * 1.5 + priceFromCategory;
            }
            else
            {
                return distance * 2 + priceFromCategory;
            }
        }
    }
}
