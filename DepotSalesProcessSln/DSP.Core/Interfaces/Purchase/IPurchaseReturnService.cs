using DSP.Core.DTO;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces.Purchase
{
    public interface IPurchaseReturnService
    {
        PurchseReturnDTO GetPurchaseReturn(string id);
        bool DeletePurchaseReturn(string id);
        bool SaveUpdatePurchaseReturn(ITN_BORPD objiTN_BOVPM);
    }
}
