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
    public class ContactService : IContact
    {
        private readonly ApplicationDBContext _context;

        public ContactService(ApplicationDBContext context)
        {
            _context = context;
        }
        public IEnumerable<ContactType> GetContactTypes()
        {
            return (IEnumerable<ContactType>)Enum.GetValues(typeof(ContactType));
        }
    }
}
