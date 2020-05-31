using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
   public interface ISalesInvoiceRepository
    {
        IEnumerable<ITN_OINV> GetAllSalesInvoice();
        IEnumerable<ITN_OINV> GetSalesInvoiceById(string id);
        bool DeleteSalesInvoice(string id);
        bool SaveSalesInvoice(ITN_OINV objITN_OINV);

        bool UpdateSalesInvoice(ITN_OINV objITN_OINV);
    }
}
