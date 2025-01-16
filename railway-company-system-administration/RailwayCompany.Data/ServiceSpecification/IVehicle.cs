using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface IVehicle
    {
        public IEnumerable<VehicleType> GetVehicleTypes();
        public IEnumerable<Vehicle> GetAll();
        Vehicle GetByRegistration(int registration);
    }
}
