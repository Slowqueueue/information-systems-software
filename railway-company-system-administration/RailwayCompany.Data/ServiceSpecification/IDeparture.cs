using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface IDeparture
    {
        public IEnumerable<Departure> GetAll();
        public Departure GetById(int id);
        public bool Add(Departure newDeparture);
        void Delete(int id);
        bool Update(Departure departure);
    }
}
