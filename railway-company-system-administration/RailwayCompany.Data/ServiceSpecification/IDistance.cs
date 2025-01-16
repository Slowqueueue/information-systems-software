using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface IDistance
    {
        public Distance CalculateDistance(City cityForm, City cityTo);
        public IEnumerable<Distance> GetAll();
    }
}
