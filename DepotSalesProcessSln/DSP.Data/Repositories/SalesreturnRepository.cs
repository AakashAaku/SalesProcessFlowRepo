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
    public class SalesReturnRepository : BaseRepository, ISalesReturnRepository
    {
        public bool DeleteSalesReturn(string id)
        {
            int deletedRows = this.dbConnection.Execute("UPDATE ITN_ORDN SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where Id = @Id", new { Id = id });
            if (deletedRows > 0)
            {
                int deletedRowsC = this.dbConnection.Execute("UPDATE ITN_RDN1  SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where ITN_ORDNID = @Id", new { Id = id });
                if (deletedRowsC > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<ITN_ORDN> GetAllSalesReturn()
        {
            return dbConnection.Query<ITN_ORDN>("SELECT * FROM ITN_ORDN");
        }

        public IEnumerable<ITN_ORDN> GetSalesReturnById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.dbConnection.Query<ITN_ORDN>("SELECT * FROM ITN_ORDN");
            }
            else
            {
                IEnumerable<ITN_ORDN> objEnum = this.dbConnection.Query<ITN_ORDN>("SELECT * FROM ITN_ORDN WHERE Id = @Id'", new { Id = id });
                if (objEnum != null)
                {
                    IEnumerable<ITN_RDN1> objEnumITN_RDN1 = this.dbConnection.Query<ITN_RDN1>("SELECT * FROM ITN_RDN1 WHERE ITN_ORDNID = @Id'", new { Id = id });
                    if (objEnumITN_RDN1 != null)
                    {
                        foreach (var data in objEnum)
                        {
                            foreach (var datachild in objEnumITN_RDN1)
                            {
                                data.ITN_RDN1.Add(datachild);
                            }
                        }
                    }
                }
                return objEnum;
            }
        }

        public bool SaveSalesReturn(ITN_ORDN objITN_ORDN)
        {
            int insertdata = this.dbConnection.Execute($@"INSERT INTO ITN_ORDN(InvoiceType,PANVATNumber,CustomerName,CustomerCode,Branch,ReferenceNo,Email,DocumentNo,Status,Postingdate,ContactPerson,DocumentOwner,TotalBeforeDiscount,DiscountPercent,Discount,TaxAmount,TotalAmount,Remarks,BaseEntry,CreatedDate,CreatedBy,DeletedFlag) VALUES('{objITN_ORDN.InvoiceType}','{objITN_ORDN.PANVATNumber}','{objITN_ORDN.CustomerName}','{objITN_ORDN.CustomerCode}','{objITN_ORDN.Branch}','{objITN_ORDN.ReferenceNo}','{objITN_ORDN.Email}','{objITN_ORDN.DocumentNo}','{objITN_ORDN.Status}',{objITN_ORDN.Postingdate},'{objITN_ORDN.ContactPerson}','{objITN_ORDN.DocumentOwner}',{objITN_ORDN.TotalBeforeDiscount},{objITN_ORDN.DiscountPercent},{objITN_ORDN.Discount},{objITN_ORDN.TaxAmount},{objITN_ORDN.TotalAmount},'{objITN_ORDN.Remarks}','{objITN_ORDN.BaseEntry}',{DateTime.Now},'ADMIN','N')");
            if (insertdata > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_ORDN.ITN_RDN1)
                {
                    this.dbConnection.Execute($@"INSERT INTO ITN_RPD1(ITN_ORDNID,ItemDescription,ItemCode,Quantity,ReturnQuantity,UnitPrice,DiscountPercent,TaxCode,TotalAmount,TaxAmount,Warehouse,BaseLine,BaseQuantity,CreatedDate,CreatedBy,DeletedFlag,SERIAL_NO,BATCH_NO) VALUES({objITN_ORDN.Id},'{data.ItemDescription}','{data.ItemCode}',{data.Quantity},{data.ReturnQuantity},{data.UnitPrice},{data.DiscountPercent},'{data.TaxCode}',{data.TotalAmount},{data.TaxAmount},'{data.Warehouse}',{data.BaseLine},{data.BaseQuantity},{DateTime.Now},'ADMIN','N',{serialNo},{serialNo})");
                    serialNo++;
                }
                return true;
            }
            return false;
        }

        public bool UpdateSalesReturn(ITN_ORDN objITN_ORDN)
        {
            int updateRows = this.dbConnection.Execute($@"UPDATE ITN_ORDN SET InvoiceType='{objITN_ORDN.InvoiceType}',PANVATNumber='{objITN_ORDN.PANVATNumber}' ,CustomerName='{objITN_ORDN.CustomerName}', CustomerCode='{objITN_ORDN.CustomerCode}' , Branch='{objITN_ORDN.Branch}',ReferenceNo='{objITN_ORDN.ReferenceNo}',Email='{objITN_ORDN.Email}',DocumentNo='{objITN_ORDN.DocumentNo}',Status='{objITN_ORDN.Status}',Postingdate={objITN_ORDN.Postingdate},ContactPerson={objITN_ORDN.ContactPerson},DocumentOwner='{objITN_ORDN.DocumentOwner}',TotalBeforeDiscount={objITN_ORDN.TotalBeforeDiscount},DiscountPercent={objITN_ORDN.DiscountPercent},Discount={objITN_ORDN.Discount},TaxAmount={objITN_ORDN.TaxAmount},TotalAmount={objITN_ORDN.TotalAmount},Remarks='{objITN_ORDN.Remarks}',,BaseEntry='{objITN_ORDN.BaseEntry}',UpdatedDate={DateTime.Now},UpdatedBy='ADMIN'");

            if (updateRows > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_ORDN.ITN_RDN1)
                {
                    this.dbConnection.Execute($@"UPDATE ITN_RDN1  SET ItemDescription='{data.ItemDescription}',ItemCode='{data.ItemCode}',Quantity={data.Quantity},ReturnQuantity={data.ReturnQuantity},UnitPrice={data.UnitPrice},DiscountPercent={data.DiscountPercent},TaxCode='{data.TaxCode}',TotalAmount={data.TotalAmount},TaxAmount={data.TotalAmount},Warehouse='{data.Warehouse}',BaseQuantity={data.BaseQuantity},BaseLine={data.BaseLine},UpadtedDate={DateTime.Now},UpdatedBy='ADMIN',DeletedFlag='N',SERIAL_NO={serialNo},BATCH_NO={serialNo}");
                    serialNo++;
                }
                return true;
            }
            return false;
        }
    }
}
