using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces.AppUser
{
    public interface IAppUsersRepository
    {
        bool AddLicense(DspUsers licenses);

        IEnumerable<DspUsers> GetAllAppUsers(); 
    }
}
