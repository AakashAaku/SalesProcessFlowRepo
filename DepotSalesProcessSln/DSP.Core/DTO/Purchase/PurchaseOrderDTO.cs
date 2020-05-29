using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class PurchaseOrderDTO
    {
        public IEnumerable<ITN_BOPOR> PurchaseOrder { get; set; }
    }
}
