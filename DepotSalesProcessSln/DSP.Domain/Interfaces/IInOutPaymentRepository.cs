using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
    public interface IInOutPaymentRepository
    {

        IEnumerable<ITN_BOVPM> GetInOutPayment(string id);
        bool DeleteInOutPayment(string id);
        bool SaveUpdateIncomingPayment(ITN_BOVPM objiTN_BOVPM);
    }
}
