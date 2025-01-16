using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public int RegistrationNumber { get; set; }
        public virtual VehicleType VehicleType { get; set; }
        public int Capacity { get; set; }
        public bool Tourist { get; set; }
    }
    public enum VehicleType
    {
        Обычный = 1,
        Скорый = 2,
        Скоростной = 3
    }
}
