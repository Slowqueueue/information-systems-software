using RailwayCompanyIS.Data;
using RailwayCompanyIS.Data.Models;
using RailwayCompanyIS.Data.ServiceSpecification;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwayCompanyIS.Service
{
    public class CityService : ICity
    {
        private readonly ApplicationDBContext _context;

        public CityService(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<City> GetAll()
        {
            return _context.Cities;
        }

        public City GetById(int id)
        {
            return GetAll().FirstOrDefault(c => c.Id == id);
        }

        public City GetByName(string name)
        {
            return GetAll()
                .FirstOrDefault(c => c.Name.ToLower() == name.ToLower());
        }

        public bool IsSameCity(City cityFrom, City cityTo)
        {
            if (cityFrom == cityTo)
                return true;
            return false;
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
