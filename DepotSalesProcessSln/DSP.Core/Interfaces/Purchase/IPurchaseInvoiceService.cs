using DSP.Core.DTO;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces.Purchase
{
    public interface IPurchaseInvoiceService
    {
        PurchaseInvoiceDTO GetPurchaseInvoice(string id);
        bool DeletePurchaseInvoice(string id);
        bool SaveUpdatePurchaseInvoice(ITN_BOPCH objiTN_BOVPM);
    }
}
