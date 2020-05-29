using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class PurchaseInvoiceDTO
    {
        public IEnumerable<ITN_BOPCH> PurchaseInvoice { get; set; }
    }
}
