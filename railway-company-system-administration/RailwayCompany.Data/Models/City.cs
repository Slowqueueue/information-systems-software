using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayCompanyIS.Data.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ZipCode { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
