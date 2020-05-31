using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class SalesInvoiceDTO
    {
        public ITN_OINV ITN_OINV { get; set; }
        public IEnumerable<ITN_OINV> SalesInvoice { get; set; }
    }
}
