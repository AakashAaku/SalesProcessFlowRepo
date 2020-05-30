using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace DSP.Domain.Interfaces
{
   public interface IStockReturnRepository
    {
        IEnumerable<ITN_ORPD> GetAllStockReturn();
        IEnumerable<ITN_ORPD> GetStockReturnById(string id);
        bool DeleteStockReturn(string id);
        bool SaveStockReturn(ITN_ORPD objITN_ORPD);

        bool UpdateStockReturn(ITN_ORPD objITN_ORPD);
    }
}
