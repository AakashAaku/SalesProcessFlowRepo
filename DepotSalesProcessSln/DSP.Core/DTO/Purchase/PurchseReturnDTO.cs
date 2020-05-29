using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class PurchseReturnDTO
    {
        public IEnumerable<ITN_BORPD> PurchaseReturn { get; set; }
    }
}
