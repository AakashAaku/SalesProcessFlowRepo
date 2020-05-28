using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
    public interface ILicenseRepository
    {
        bool AddLicense(List<Licenses> licenses);

        IEnumerable<Licenses> GetAllLicenses();
    }
}
