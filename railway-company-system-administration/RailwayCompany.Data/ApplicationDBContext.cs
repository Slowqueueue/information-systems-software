using RailwayCompanyIS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace RailwayCompanyIS.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext()
        {

        }

        public ApplicationDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Departure> Departures { get; set; }
        public DbSet<Distance> Distances { get; set; }
        public DbSet<PaymentCategory> PaymentCategories { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
    }
}
