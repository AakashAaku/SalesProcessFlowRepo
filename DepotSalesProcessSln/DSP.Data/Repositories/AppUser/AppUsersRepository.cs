using DSP.Domain.Interfaces.AppUser;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Data.Repositories.AppUser
{
    public class AppUsersRepository : IAppUsersRepository
    {
        public bool AddLicense(DspUsers licenses)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DspUsers> GetAllAppUsers()
        {
            throw new NotImplementedException();
        }
    }
}
