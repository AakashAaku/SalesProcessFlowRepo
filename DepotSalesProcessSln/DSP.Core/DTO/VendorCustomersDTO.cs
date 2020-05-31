using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class VendorCustomersDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<VendorCustomers> Customers { get; set; } 

        public VendorCustomers VendorCustomers { get; set; }
    }
}
