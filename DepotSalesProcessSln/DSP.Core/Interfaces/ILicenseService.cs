using DSP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces
{
    public interface ILicenseService
    {
        bool SaveLicence(List<LicensesDTO> licenses);

        LicensesDTO GetAllLicense();
    }
}
