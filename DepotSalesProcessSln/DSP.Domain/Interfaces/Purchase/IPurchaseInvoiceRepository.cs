using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces.Purchase
{
    public interface IPurchaseInvoiceRepository
    {
        IEnumerable<ITN_BOPCH> GetPurchaseInvoice(string id);
        bool DeletePurchaseInvoice(string id);
        bool SaveUpdatePurchaseInvoice(ITN_BOPCH objiTN_BOVPM);
    }
}
