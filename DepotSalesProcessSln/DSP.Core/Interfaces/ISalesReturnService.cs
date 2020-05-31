using System;
using System.Collections.Generic;
using System.Text;
using DSP.Core.DTO;

namespace DSP.Core.Interfaces
{
    public interface ISalesReturnService
    {
       SalesReturnDTO  GetAllSalesInvoiceReq();

        bool SaveSalesInvoiceReq(SalesReturnDTO str);

        bool UpdateSalesInvoiceReq(SalesReturnDTO str);

        SalesReturnDTO GetSalesInvoiceById(string id);

        bool DeleteSalesInvoice(string id);
    }
}
