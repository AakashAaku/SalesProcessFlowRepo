using DSP.Data.Context;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Data.Repositories
{
    public class CustomersRepository : ICustomersRepository
    {

        private DSPMainDbContext _context;

        public CustomersRepository(DSPMainDbContext dbContext)
        {
            _context = dbContext;
        }

        public IEnumerable<Customers> GetAllCustomers()
        {
            return _context.Customers;
        }
    }
}
