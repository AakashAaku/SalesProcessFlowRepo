using DSP.Core.DTO;
using DSP.Core.Interfaces.Purchase;
using DSP.Domain.Interfaces.Purchase;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services.Purchase
{
    public class PurchaseOrderService: IPurchaseOrderService
    {
        public IPurchaseOrderRepository _iPurchaseOrderRepository;
        public PurchaseOrderService(IPurchaseOrderRepository iPurchaseOrderRepository)
        {
            _iPurchaseOrderRepository = iPurchaseOrderRepository;
        }
        public PurchaseOrderDTO GetPurchaseOrder(string id)
        {
            return new PurchaseOrderDTO
            {
                PurchaseOrder = _iPurchaseOrderRepository.GetPurchaseOrder(id)
            };
        }
        public bool DeletePurchaseOrder(string id)
        {
            return _iPurchaseOrderRepository.DeletePurchaseOrder(id);
        }
        public bool SaveUpdatePurchaseOrder(ITN_BOPOR objiTN_BOVPM)
        {
            return _iPurchaseOrderRepository.SaveUpdatePurchaseOrder(objiTN_BOVPM);
        }
    }
}
