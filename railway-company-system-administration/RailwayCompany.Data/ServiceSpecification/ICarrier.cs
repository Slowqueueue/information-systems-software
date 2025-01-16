using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface ICarrier
    {
        Carrier GetById(int id);
        IEnumerable<Carrier> GetAll();
        IEnumerable<Carrier> GetByCity(City city);
        bool AddNewCarrier(Carrier carrier);
        bool Update(Carrier carrier);
        bool Delete(int id);
        Carrier GetByName(string name);
        bool CheckDep(int id);
    }
}
