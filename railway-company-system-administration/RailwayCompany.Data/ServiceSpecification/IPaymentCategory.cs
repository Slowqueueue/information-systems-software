using RailwayCompanyIS.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.ServiceSpecification
{
    public interface IPaymentCategory
    {
        public IEnumerable<PaymentCategory> GetAll();
        public PaymentCategory GetByName(string categoryName);
    }
}
