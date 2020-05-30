using DSP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces
{
   public interface IStockReceiptService
    {
        StockReceiptDTO GetAllStockReceiptReq();

        bool SaveStockReceiptReq(StockReceiptDTO str);

        bool UpdateStockReceiptReq(StockReceiptDTO str);

        StockReceiptDTO GetStockReceiptRequestById(string id);

        bool DeleteStockReceipt(string id);

    }
}
