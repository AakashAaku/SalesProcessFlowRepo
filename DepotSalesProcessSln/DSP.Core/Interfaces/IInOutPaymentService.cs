using DSP.Core.DTO;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces
{
    public interface IInOutPaymentService
    {
        InOutPaymentDTO GetInOutPayment(string id);
        bool DeleteInOutPayment(string id);
        bool SaveUpdateIncomingPayment(ITN_BOVPM objiTN_BOVPM);
    }
}
