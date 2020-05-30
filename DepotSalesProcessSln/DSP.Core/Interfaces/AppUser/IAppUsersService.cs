using DSP.Core.DTO.AppUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces.AppUser
{
    public interface IAppUsersService
    {
        bool SaveAppUser(AppUsersDTO appUser); 

        AppUsersDTO GetAllAppUser(); 
    }
}
