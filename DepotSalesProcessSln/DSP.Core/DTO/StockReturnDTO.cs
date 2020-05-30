using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.DTO
{
    public class StockReturnDTO
    {
        public ITN_ORPD ITN_ORPD { get; set; }
        public IEnumerable<ITN_ORPD> StockReturn { get; set; }
    }
}
