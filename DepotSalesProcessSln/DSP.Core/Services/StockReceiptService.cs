using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class StockReceiptService : IStockReceiptService
    {
        public IStockReceiptRepository _iStockReceiptRepository;
        public StockReceiptService(IStockReceiptRepository iStockReceiptRepository)
        {
            _iStockReceiptRepository = iStockReceiptRepository;
        }
        public bool DeleteStockReceipt(string id)
        {
            return _iStockReceiptRepository.DeleteStockReceipt(id);
        }

        public StockReceiptDTO GetAllStockReceiptReq()
        {
            return new StockReceiptDTO
            {
                StockReceipt = _iStockReceiptRepository.GetAllStockReceipt()
            };
        }

        public StockReceiptDTO GetStockReceiptRequestById(string id)
        {
            return new StockReceiptDTO
            {
                StockReceipt = _iStockReceiptRepository.GetStockReceiptById(id)
            };
        }

        public bool SaveStockReceiptReq(StockReceiptDTO str)
        {
            return _iStockReceiptRepository.SaveStockReceipt(str.ITN_OPDN);
        }

        public bool UpdateStockReceiptReq(StockReceiptDTO str)
        {
            throw new NotImplementedException();
        }
    }
}
