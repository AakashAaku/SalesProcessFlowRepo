using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class StockReturnService : IStockReturnService
    {
        public IStockReturnRepository _iStockReturnRepository;
        public StockReturnService(IStockReturnRepository iStockReturnRepository)
        {
            _iStockReturnRepository = iStockReturnRepository;
        }
        public bool DeleteStockReturn(string id)
        {
            return _iStockReturnRepository.DeleteStockReturn(id);
        }

        public StockReturnDTO GetAllStockReturnReq()
        {
            return new StockReturnDTO
            {
                StockReturn = _iStockReturnRepository.GetAllStockReturn()
            };
        }

        public StockReturnDTO GetStockReturnById(string id)
        {
            return new StockReturnDTO
            {
                StockReturn = _iStockReturnRepository.GetStockReturnById(id)
            };
        }

        public bool SaveStockReturnReq(StockReturnDTO str)
        {
            return _iStockReturnRepository.SaveStockReturn(str.ITN_ORPD);
        }

        public bool UpdateStockReturnReq(StockReturnDTO str)
        {
            return _iStockReturnRepository.UpdateStockReturn(str.ITN_ORPD);
        }
    }
}
