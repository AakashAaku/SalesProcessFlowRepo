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
    public class StockReceiptRepository : BaseRepository, IStockReceiptRepository
    {
        public bool DeleteStockReceipt(string id)
        {
            int deletedRows = this.dbConnection.Execute("UPDATE ITN_OPDN SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where Id = @Id", new { Id = id });
            if (deletedRows > 0)
            {
                int deletedRowsC = this.dbConnection.Execute("UPDATE ITN_PDN1 SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where ITN_ORPDID = @Id", new { Id = id });
                if (deletedRowsC > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<ITN_OPDN> GetAllStockReceipt()
        {
            return dbConnection.Query<ITN_OPDN>("SELECT * FROM ITN_OPDN");
        }

        public IEnumerable<ITN_OPDN> GetStockReceiptById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.dbConnection.Query<ITN_OPDN>("SELECT * FROM ITN_OPDN");
            }
            else
            {
                IEnumerable<ITN_OPDN> objEnum = this.dbConnection.Query<ITN_OPDN>("SELECT * FROM ITN_OPDN WHERE Id = @IId'", new { Id = id });
                if (objEnum != null)
                {
                    IEnumerable<ITN_PDN1> objEnumITN_PDN1 = this.dbConnection.Query<ITN_PDN1>("SELECT * FROM ITN_PDN1 WHERE ITN_OPDNID = @Id'", new { Id = id });
                    if (objEnumITN_PDN1 != null)
                    {
                        foreach (var data in objEnum)
                        {
                            foreach (var datachild in objEnumITN_PDN1)
                            {
                                data.ITN_PDN1.Add(datachild);
                            }
                        }
                    }
                }
                return objEnum;
            }
        }

        public bool SaveStockReceipt(ITN_OPDN objITN_OPDN)
        {
            int insertdata = this.dbConnection.Execute($@"INSERT INTO ITN_OPDN(VendorName,VendorCode,Branch,ReferenceNo,Email,DocumentNo,Status,PostingDate,ReceivedDate,ContactPerson,DocumentOwner,TotalBeforeDiscount,DiscountPercent,Discount,TaxAmount,TotalAmount,Remarks,BaseEntry,CreatedDate,CreatedBy,DeletedFlag) VALUES('{objITN_OPDN.VendorName}','{objITN_OPDN.VendorCode}','{objITN_OPDN.Branch}','{objITN_OPDN.ReferenceNo}','{objITN_OPDN.Email}','{objITN_OPDN.DocumentNo}','{objITN_OPDN.Status}',{objITN_OPDN.PostingDate},{objITN_OPDN.ReceivedDate},'{objITN_OPDN.ContactPerson}','{objITN_OPDN.DocumentOwner}',{objITN_OPDN.TotalBeforeDiscount},{objITN_OPDN.DiscountPercent},{objITN_OPDN.Discount},{objITN_OPDN.TaxAmount},{objITN_OPDN.TotalAmount},'{objITN_OPDN.Remarks}','{objITN_OPDN.BaseEntry}',{DateTime.Now},'ADMIN','N')");
            if (insertdata > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_OPDN.ITN_PDN1)
                {
                    this.dbConnection.Execute($@"INSERT INTO ITN_PRO1(ITN_OPDNID,ItemDescription,ItemCode,RequestedQuantity,ReceivedQuantity,DamagedQuantity,UnitPrice,DiscountPercent,TaxCode,TotalAmount,TaxAmount,Warehouse,ReturnQuantity,SoldQuantity,CreatedDate,CreatedBy,DeletedFlag,SERIAL_NO,BATCH_NO) VALUES({objITN_OPDN.Id},'{data.ItemDescription}','{data.ItemCode}',{data.RequestedQuantity},{data.ReceivedQuantity},{data.DamagedQuantity},{data.UnitPrice},{data.DiscountPercent},'{data.TaxCode}',{data.TotalAmount},{data.TaxAmount},'{data.Warehouse}',{data.ReturnQuantity},{data.SoldQuantity},{DateTime.Now},'ADMIN','N',{serialNo},{serialNo})");
                    serialNo++;
                }
                return true;
            }
            return false;
        }

        public bool UpdateStockReceipt(ITN_OPDN objITN_OPDN)
        {
            int updateRows = this.dbConnection.Execute($@"UPDATE ITN_OPDN SET VendorName='{objITN_OPDN.VendorName}', VendorCode='{objITN_OPDN.VendorCode}' , Branch='{objITN_OPDN.Branch}',ReferenceNo='{objITN_OPDN.ReferenceNo}',Email='{objITN_OPDN.Email}',DocumentNo='{objITN_OPDN.DocumentNo}',Status='{objITN_OPDN.Status}',PostingDate={objITN_OPDN.PostingDate},ReceivedDate={objITN_OPDN.ReceivedDate},ContactPerson={objITN_OPDN.ContactPerson},DocumentOwner='{objITN_OPDN.DocumentOwner}',TotalBeforeDiscount={objITN_OPDN.TotalBeforeDiscount},DiscountPercent={objITN_OPDN.DiscountPercent},Discount={objITN_OPDN.Discount},TaxAmount={objITN_OPDN.TaxAmount},TotalAmount={objITN_OPDN.TotalAmount},Remarks='{objITN_OPDN.Remarks}',,BaseEntry='{objITN_OPDN.BaseEntry}',UpdatedDate={DateTime.Now},UpdatedBy='ADMIN'");

            if (updateRows > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_OPDN.ITN_PDN1)
                {
                    this.dbConnection.Execute($@"UPDATE ITN_PRO1 SET ItemDescription='{data.ItemDescription}',ItemCode='{data.ItemCode}',Quantity={data.RequestedQuantity},ReceivedQty={data.ReceivedQuantity},DamagedQuantity={data.DamagedQuantity},UnitPrice={data.UnitPrice},DiscountPercent={data.DiscountPercent},TaxCode='{data.TaxCode}',TotalAmount={data.TotalAmount},TaxAmount={data.TotalAmount},Warehouse='{data.Warehouse}',ReturnQuantity={data.ReturnQuantity},SoldQuantity={data.SoldQuantity},UpadtedDate={DateTime.Now},UpdatedBy='ADMIN',DeletedFlag='N',SERIAL_NO={serialNo},BATCH_NO={serialNo}");
                    serialNo++;
                }
                return true;
            }
            return false;
        }
    }
}
