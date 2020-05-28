using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class ITN_OPROService: IITN_OPROService
    {
        public IITN_OPRORepository _itnRepository;

        public ITN_OPROService(IITN_OPRORepository itnRepository)
        {
            _itnRepository = itnRepository;
        }

        public ITN_OPRODTO GetAllITN_OPRO()
        {
            return new ITN_OPRODTO
            {
                //Customers = _customerRepository.GetAllCustomers()
            };
        }
    }
}
