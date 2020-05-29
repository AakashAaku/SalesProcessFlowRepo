using DSP.Core.DTO;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces.Purchase
{
    public interface IPurchaseOrderService
    {
        PurchaseOrderDTO GetPurchaseOrder(string id);
        bool DeletePurchaseOrder(string id);
        bool SaveUpdatePurchaseOrder(ITN_BOPOR objiTN_BOVPM);
    }
}
