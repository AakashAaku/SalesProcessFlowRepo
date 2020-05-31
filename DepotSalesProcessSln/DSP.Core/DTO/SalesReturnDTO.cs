using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class SalesReturnDTO
    {
        public ITN_ORDN ITN_ORDN { get; set; }
        public IEnumerable<ITN_ORDN> SalesReturn { get; set; }
    }
}
