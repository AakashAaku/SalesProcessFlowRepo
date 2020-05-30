using DSP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces
{
    public interface IITN_OPROService
    {
        ITN_OPRODTO GetAllStockTransferReq();

        bool SaveStockTransferReq(ITN_OPRODTO str);

        bool UpdateStockTransferReq(ITN_OPRODTO str);

        ITN_OPRODTO GetStockTransferRequestById(string id);

        bool DeleteStockTransferRequest(string id);
    }
}
