using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces.Purchase
{
    public interface IPurchaseOrderRepository
    {
        IEnumerable<ITN_BOPOR> GetPurchaseOrder(string id);
        bool DeletePurchaseOrder(string id);
        bool SaveUpdatePurchaseOrder(ITN_BOPOR objiTN_BOVPM);
    }
}
