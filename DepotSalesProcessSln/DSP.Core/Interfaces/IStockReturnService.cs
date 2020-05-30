using DSP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces
{
   public interface IStockReturnService
    {
        StockReturnDTO GetAllStockReturnReq();

        bool SaveStockReturnReq(StockReturnDTO str);

        bool UpdateStockReturnReq(StockReturnDTO str);

        StockReturnDTO GetStockReturnById(string id);

        bool DeleteStockReturn(string id);

    }
}
