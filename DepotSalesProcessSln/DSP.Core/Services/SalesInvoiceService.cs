using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class SalesInvoiceService : ISalesInvoiceService
    {
        public ISalesInvoiceRepository _iSalesInvoiceRepository;
        public SalesInvoiceService(ISalesInvoiceRepository iSalesInvoiceRepository)
        {
            _iSalesInvoiceRepository = iSalesInvoiceRepository;
        }
        public bool DeleteSalesInvoice(string id)
        {
            return _iSalesInvoiceRepository.DeleteSalesInvoice(id);
        }

        public SalesInvoiceDTO GetAllSalesInvoiceReq()
        {
            return new SalesInvoiceDTO
            {
                SalesInvoice = _iSalesInvoiceRepository.GetAllSalesInvoice()
            };
        }

            public SalesInvoiceDTO GetSalesInvoiceById(string id)
        {
            return new SalesInvoiceDTO
            {
                SalesInvoice = _iSalesInvoiceRepository.GetSalesInvoiceById(id)
            };
        }

        public bool SaveSalesInvoiceReq(SalesInvoiceDTO str)
        {
            return _iSalesInvoiceRepository.SaveSalesInvoice(str.ITN_OINV);
        }

        public bool UpdateSalesInvoiceReq(SalesInvoiceDTO str)
        {
            return _iSalesInvoiceRepository.UpdateSalesInvoice(str.ITN_OINV);
        }
    }
}
