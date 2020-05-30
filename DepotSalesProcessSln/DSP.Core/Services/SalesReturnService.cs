using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class SalesReturnService : ISalesReturnService
    {
        private readonly ISalesReturnRepository _iSalesReturnRepository;

        public SalesReturnService(ISalesReturnRepository iSalesReturnRepository)
        {
            this._iSalesReturnRepository = iSalesReturnRepository;
        }
        public bool DeleteSalesInvoice(string id)
        {
            return _iSalesReturnRepository.DeleteSalesReturn(id);
        }

        public SalesReturnDTO GetAllSalesInvoiceReq()
        {
            return new SalesReturnDTO
            {
                SalesReturn = _iSalesReturnRepository.GetAllSalesReturn()
            };
        }

        public SalesReturnDTO GetSalesInvoiceById(string id)
        {
            return new SalesReturnDTO
            {
                SalesReturn = _iSalesReturnRepository.GetSalesReturnById(id)
            };
        }

        public bool SaveSalesInvoiceReq(SalesReturnDTO str)
        {
            return _iSalesReturnRepository.SaveSalesReturn(str.ITN_ORDN);
        }

        public bool UpdateSalesInvoiceReq(SalesReturnDTO str)
        {
            return _iSalesReturnRepository.UpdateSalesReturn(str.ITN_ORDN);
        }
    }
}
