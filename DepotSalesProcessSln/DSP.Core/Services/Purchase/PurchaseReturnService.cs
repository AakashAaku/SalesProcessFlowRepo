using DSP.Core.DTO;
using DSP.Core.Interfaces.Purchase;
using DSP.Domain.Interfaces.Purchase;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services.Purchase
{
    public class PurchaseReturnService: IPurchaseReturnService
    {
        public IPurchaseReturnRepository _iPurchaseReturnRepository;
        public PurchaseReturnService(IPurchaseReturnRepository iPurchaseReturnRepository)
        {
            _iPurchaseReturnRepository = iPurchaseReturnRepository;
        }
        public PurchseReturnDTO GetPurchaseInvoice(string id)
        {
            return new PurchseReturnDTO
            {
                PurchaseReturn = _iPurchaseReturnRepository.GetPurchaseReturn(id)
            };
        }
        public bool DeletePurchaseReturn(string id)
        {
            return _iPurchaseReturnRepository.DeletePurchaseReturn(id);
        }
        public bool SaveUpdatePurchaseReturn(ITN_BORPD objiTN_BOVPM)
        {
            return _iPurchaseReturnRepository.SaveUpdatePurchaseReturn(objiTN_BOVPM);
        }
    }
}
