using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class StockReceiptDTO
    {
        public ITN_OPDN ITN_OPDN { get; set; }
        public IEnumerable<ITN_OPDN> StockReceipt { get; set; }
    }
}
