using RailwayCompanyIS.Data;
using RailwayCompanyIS.Data.Models;
using RailwayCompanyIS.Data.ServiceSpecification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RailwayCompanyIS.Service
{
    public class DepartureService : IDeparture
    {
        private readonly ApplicationDBContext _context;

        public DepartureService(ApplicationDBContext context)
        {
            _context = context;
        }

        public bool Add(Departure newDeparture)
        {
            try
            {
                _context.Add(newDeparture);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void Delete(int id)
        {
            _context.Departures.Remove(GetById(id));
            _context.SaveChanges();
        }

        public IEnumerable<Departure> GetAll()
        {
            return _context.Departures
                .Include(d => d.CityFrom)
                .Include(d => d.CityTo)
                
                .Include(d => d.Distance)
                .Include(d => d.Carrier)
                    .ThenInclude(c => c.Address)
                .Include(d => d.PaymentCategory)
                .Include(d => d.Vehicle);
        }

        public Departure GetById(int id)
        {
            return GetAll()
                .FirstOrDefault(d => d.Id == id);
        }

        public bool Update(Departure departure)
        {
            try
            {
                _context.Departures.Update(departure);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
