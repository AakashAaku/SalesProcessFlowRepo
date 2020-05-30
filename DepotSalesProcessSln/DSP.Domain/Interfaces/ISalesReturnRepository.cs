using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
   public interface ISalesReturnRepository
    {
        IEnumerable<ITN_ORDN> GetAllSalesReturn();
        IEnumerable<ITN_ORDN> GetSalesReturnById(string id);
        bool DeleteSalesReturn(string id);
        bool SaveSalesReturn(ITN_ORDN objITN_ORDN);

        bool UpdateSalesReturn(ITN_ORDN objITN_ORDN);


    }
}
