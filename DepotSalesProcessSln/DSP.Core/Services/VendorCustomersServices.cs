using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class VendorCustomersServices : IVendorCustomersService
    {
        public IVendorCustomersRepository _customerRepository;

        public VendorCustomersServices(IVendorCustomersRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public VendorCustomersDTO GetAllCustomer()
        {
            return new VendorCustomersDTO
            {
                Customers = _customerRepository.GetAllCustomers()
            };
        }
    }
}
