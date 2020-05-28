using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSP.Core.Services
{
    public class LicenseService : ILicenseService
    {
        private readonly ILicenseRepository _licenseRepository;

        public LicenseService(ILicenseRepository licenseRepository)
        {
            this._licenseRepository = licenseRepository;
        }

        public LicensesDTO GetAllLicense()
        {
            try
            {
                return new LicensesDTO
                {
                    Licenses = _licenseRepository.GetAllLicenses()
                };
            }
            catch (Exception ex)
            {

                throw new Exception("Error while getting all license : " + ex.StackTrace);
            }
            
        }

        public bool SaveLicence(LicensesDTO licenses)
        {
            try
            {

                var result = _licenseRepository.AddLicense(licenses.Licenses.ToList());
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Error while saving license : " + ex.StackTrace);
            }
        }

        public bool SaveLicence(List<LicensesDTO> licenses)
        {
            throw new NotImplementedException();
        }
    }
}
