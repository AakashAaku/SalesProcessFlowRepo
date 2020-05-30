using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
    public interface IStockReceiptRepository
    {
        IEnumerable<ITN_OPDN> GetAllStockReceipt();
        IEnumerable<ITN_OPDN> GetStockReceiptById(string id);
        bool DeleteStockReceipt(string id);
        bool SaveStockReceipt(ITN_OPDN objITN_OPDN);

        bool UpdateStockReceipt(ITN_OPDN objITN_OPDN);
    }
}
