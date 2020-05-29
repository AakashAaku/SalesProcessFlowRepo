using DSP.Core.DTO;
using DSP.Core.Interfaces.Purchase;
using DSP.Domain.Interfaces.Purchase;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services.Purchase
{
    public class PurchaseInvoiceService: IPurchaseInvoiceService
    {
        public IPurchaseInvoiceRepository _iPurchaseInvoiceRepository;
        public PurchaseInvoiceService(IPurchaseInvoiceRepository iPurchaseInvoiceRepository)
        {
            _iPurchaseInvoiceRepository = iPurchaseInvoiceRepository;
        }
        public PurchaseInvoiceDTO GetPurchaseInvoice(string id)
        {
            return new PurchaseInvoiceDTO
            {
                PurchaseInvoice = _iPurchaseInvoiceRepository.GetPurchaseInvoice(id)
            };
        }
        public bool DeletePurchaseInvoice(string id)
        {
            return _iPurchaseInvoiceRepository.DeletePurchaseInvoice(id);
        }
        public bool SaveUpdatePurchaseInvoice(ITN_BOPCH objiTN_BOVPM)
        {
            return _iPurchaseInvoiceRepository.SaveUpdatePurchaseInvoice(objiTN_BOVPM);
        }
    }
}
