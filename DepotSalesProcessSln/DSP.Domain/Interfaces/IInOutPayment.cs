using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
    public interface IInOutPayment
    {
        IEnumerable<ITN_BOVPM> GetInOutPayment(string id);
        bool IncomingPayment(string id);
    }
}
