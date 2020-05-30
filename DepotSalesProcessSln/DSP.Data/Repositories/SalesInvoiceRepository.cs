using Dapper;
using DSP.Data.Context;
using DSP.Domain.Interfaces;
using DSP.Domain.Interfaces.Purchase;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
namespace DSP.Data.Repositories
{
    public class SalesInvoiceRepository : BaseRepository, ISalesInvoiceRepository
    {
        public bool DeleteSalesInvoice(string id)
        {
            int deletedRows = this.dbConnection.Execute("UPDATE ITN_OINV SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where Id = @Id", new { Id = id });
            if (deletedRows > 0)
            {
                int deletedRowsC = this.dbConnection.Execute("UPDATE ITN_INV1  SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where ITN_OINVID = @Id", new { Id = id });
                if (deletedRowsC > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<ITN_OINV> GetAllSalesInvoice()
        {
            return dbConnection.Query<ITN_OINV>("SELECT * FROM ITN_OINV");
        }

        public IEnumerable<ITN_OINV> GetSalesInvoiceById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.dbConnection.Query<ITN_OINV>("SELECT * FROM ITN_OINV");
            }
            else
            {
                IEnumerable<ITN_OINV> objEnum = this.dbConnection.Query<ITN_OINV>("SELECT * FROM ITN_OINV WHERE Id = @Id'", new { Id = id });
                if (objEnum != null)
                {
                    IEnumerable<ITN_INV1> objEnumITN_INV1 = this.dbConnection.Query<ITN_INV1>("SELECT * FROM ITN_INV1 WHERE ITN_OINVID = @Id'", new { Id = id });
                    if (objEnumITN_INV1 != null)
                    {
                        foreach (var data in objEnum)
                        {
                            foreach (var datachild in objEnumITN_INV1)
                            {
                                data.ITN_INV1.Add(datachild);
                            }
                        }
                    }
                }
                return objEnum;
            }
        }

        public bool SaveSalesInvoice(ITN_OINV objITN_OINV)
        {
            int insertdata = this.dbConnection.Execute($@"INSERT INTO ITN_OINV(InvoiceType,PANVATNumber,CustomerName,CustomerCode,Branch,ReferenceNo,Email,DocumentNo,Status,Postingdate,ContactPerson,DocumentOwner,TotalBeforeDiscount,DiscountPercent,Discount,TaxAmount,TotalAmount,Remarks,BaseEntry,AmountPaid,AmountReturn,CreatedDate,CreatedBy,DeletedFlag) VALUES('{objITN_OINV.InvoiceType}','{objITN_OINV.PANVATNumber}','{objITN_OINV.CustomerName}','{objITN_OINV.CustomerCode}','{objITN_OINV.Branch}','{objITN_OINV.ReferenceNo}','{objITN_OINV.Email}','{objITN_OINV.DocumentNo}','{objITN_OINV.Status}',{objITN_OINV.Postingdate},'{objITN_OINV.ContactPerson}','{objITN_OINV.DocumentOwner}',{objITN_OINV.TotalBeforeDiscount},{objITN_OINV.DiscountPercent},{objITN_OINV.Discount},{objITN_OINV.TaxAmount},{objITN_OINV.TotalAmount},'{objITN_OINV.Remarks}','{objITN_OINV.BaseEntry}',{objITN_OINV.AmountPaid},{objITN_OINV.AmountReturn},{DateTime.Now},'ADMIN','N')");
            if (insertdata > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_OINV.ITN_INV1)
                {
                    this.dbConnection.Execute($@"INSERT INTO ITN_RPD1(ITN_ORPDID,ItemDescription,ItemCode,Quantity,UnitPrice,DiscountPercent,TaxCode,TotalAmount,TaxAmount,Warehouse,BaseQuantity,BaseAmount,CreatedDate,CreatedBy,DeletedFlag,SERIAL_NO,BATCH_NO) VALUES({objITN_OINV.Id},'{data.ItemDescription}','{data.ItemCode}',{data.Quantity},{data.UnitPrice},{data.DiscountPercent},'{data.TaxCode}',{data.TotalAmount},{data.TaxAmount},'{data.Warehouse}',{data.BaseQuantity},{data.BaseAmount},{DateTime.Now},'ADMIN','N',{serialNo},{serialNo})");
                    serialNo++;
                }
                return true;
            }
            return false;
        }

        public bool UpdateSalesInvoice(ITN_OINV objITN_OINV)
        {
            int updateRows = this.dbConnection.Execute($@"UPDATE ITN_OINV SET InvoiceType='{objITN_OINV.InvoiceType}',PANVATNumber='{objITN_OINV.PANVATNumber}' ,CustomerName='{objITN_OINV.CustomerName}', CustomerCode='{objITN_OINV.CustomerCode}' , Branch='{objITN_OINV.Branch}',ReferenceNo='{objITN_OINV.ReferenceNo}',Email='{objITN_OINV.Email}',DocumentNo='{objITN_OINV.DocumentNo}',Status='{objITN_OINV.Status}',Postingdate={objITN_OINV.Postingdate},ContactPerson={objITN_OINV.ContactPerson},DocumentOwner='{objITN_OINV.DocumentOwner}',TotalBeforeDiscount={objITN_OINV.TotalBeforeDiscount},DiscountPercent={objITN_OINV.DiscountPercent},Discount={objITN_OINV.Discount},TaxAmount={objITN_OINV.TaxAmount},TotalAmount={objITN_OINV.TotalAmount},Remarks='{objITN_OINV.Remarks}',,BaseEntry='{objITN_OINV.BaseEntry}',AmountPaid={objITN_OINV.AmountPaid},AmountReturn={objITN_OINV.AmountReturn},UpdatedDate={DateTime.Now},UpdatedBy='ADMIN'");

            if (updateRows > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_OINV.ITN_INV1)
                {
                    this.dbConnection.Execute($@"UPDATE ITN_INV1  SET ItemDescription='{data.ItemDescription}',ItemCode='{data.ItemCode}',Quantity={data.Quantity},UnitPrice={data.UnitPrice},DiscountPercent={data.DiscountPercent},TaxCode='{data.TaxCode}',TotalAmount={data.TotalAmount},TaxAmount={data.TotalAmount},Warehouse='{data.Warehouse}',BaseQuantity={data.BaseQuantity},BaseAmount={data.BaseAmount},UpadtedDate={DateTime.Now},UpdatedBy='ADMIN',DeletedFlag='N',SERIAL_NO={serialNo},BATCH_NO={serialNo}");
                    serialNo++;
                }
                return true;
            }
            return false;
        }
    }
}
