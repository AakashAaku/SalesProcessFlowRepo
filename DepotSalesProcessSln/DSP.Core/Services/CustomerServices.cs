using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class CustomerServices : ICustomersService
    {
        public ICustomersRepository _customerRepository;

        public CustomerServices(ICustomersRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public CustomersDTO GetAllCustomer()
        {
            return new CustomersDTO
            {
                Customers = _customerRepository.GetAllCustomers()
            };
        }
    }
}
