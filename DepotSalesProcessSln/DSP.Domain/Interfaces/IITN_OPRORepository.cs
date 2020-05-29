using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
   public interface IITN_OPRORepository
    {
        IEnumerable<ITN_OPRO> GetAllStockTransferRequest();
        IEnumerable<ITN_OPRO> GetStockTransferRequestById(string id);
        
        bool InsertStockTransferRequest(ITN_OPRO itn_opro);
        //bool DeleteStockTransferRequest(int Id);
        bool UpdateStockTransferRequest(ITN_OPRO itn_opro);
    }
}
