using Dapper;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Data.Repositories
{
    public class LicenseRepository : BaseRepository, ILicenseRepository
    {
        public bool AddLicense(List<Licenses> licenses)
        {
            try
            {
                if (licenses.Count > 0)
                {
                    foreach(var lmodel in licenses)
                    {
                        dbConnection.Execute("INSERT INTO License(Type,License) VALUES(@Name,@License)",new {lmodel.Type,lmodel.License });
                        return true;
                    }
                   
                }
                return false;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.StackTrace);
            }
        }

        public IEnumerable<Licenses> GetAllLicenses()
        {
            try
            {
                var allLicense = dbConnection.Query<Licenses>("SELECT * FROM Licenses");
                return allLicense;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.StackTrace);
            }
        }
    }
}
