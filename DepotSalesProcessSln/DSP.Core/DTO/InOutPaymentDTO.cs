using System;
using System.Collections.Generic;
using System.Text;
using DSP.Domain.Models;

namespace DSP.Core.DTO
{
    public class InOutPaymentDTO
    {
        public IEnumerable<ITN_BOVPM> InOutPayment { get; set; }
        public ITN_BOVPM InOutPay { get; set; }
    }
}
