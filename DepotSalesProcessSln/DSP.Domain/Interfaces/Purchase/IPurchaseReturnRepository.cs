using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces.Purchase
{
    public interface IPurchaseReturnRepository
    {
        IEnumerable<ITN_BORPD> GetPurchaseReturn(string id);
        bool DeletePurchaseReturn(string id);
        bool SaveUpdatePurchaseReturn(ITN_BORPD objiTN_BOVPM);
    }
}
