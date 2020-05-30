using DSP.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Interfaces
{
    public interface ISalesInvoiceService
    {
        SalesInvoiceDTO GetAllSalesInvoiceReq();

        bool SaveSalesInvoiceReq(SalesInvoiceDTO str);

        bool UpdateSalesInvoiceReq(SalesInvoiceDTO str);

        SalesInvoiceDTO GetSalesInvoiceById(string id);

        bool DeleteSalesInvoice(string id);
    }
}
