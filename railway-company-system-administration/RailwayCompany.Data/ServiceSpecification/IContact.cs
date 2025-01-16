using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface IContact
    {
        IEnumerable<ContactType> GetContactTypes();
    }
}
