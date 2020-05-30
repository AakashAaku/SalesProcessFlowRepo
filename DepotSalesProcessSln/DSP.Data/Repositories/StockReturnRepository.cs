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
    public class StockReturnRepository : BaseRepository, IStockReturnRepository
    {
        public bool DeleteStockReturn(string id)
        {
            int deletedRows = this.dbConnection.Execute("UPDATE ITN_ORPD SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where Id = @Id", new { Id = id });
            if (deletedRows > 0)
            {
                int deletedRowsC = this.dbConnection.Execute("UPDATE ITN_RPD1  SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where ITN_OPDNID = @Id", new { Id = id });
                if (deletedRowsC > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerable<ITN_ORPD> GetAllStockReturn()
        {
            return dbConnection.Query<ITN_ORPD>("SELECT * FROM ITN_ORPD");
        }

        public IEnumerable<ITN_ORPD> GetStockReturnById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.dbConnection.Query<ITN_ORPD>("SELECT * FROM ITN_ORPD");
            }
            else
            {
                IEnumerable<ITN_ORPD> objEnum = this.dbConnection.Query<ITN_ORPD>("SELECT * FROM ITN_ORPD WHERE Id = @IId'", new { Id = id });
                if (objEnum != null)
                {
                    IEnumerable<ITN_RPD1> objEnumITN_RPD1 = this.dbConnection.Query<ITN_RPD1>("SELECT * FROM ITN_RPD1 WHERE ITN_ORPDID = @Id'", new { Id = id });
                    if (objEnumITN_RPD1 != null)
                    {
                        foreach (var data in objEnum)
                        {
                            foreach (var datachild in objEnumITN_RPD1)
                            {
                                data.ITN_RPD1.Add(datachild);
                            }
                        }
                    }
                }
                return objEnum;
            }
        }

        public bool SaveStockReturn(ITN_ORPD objITN_ORPD)
        {
            int insertdata = this.dbConnection.Execute($@"INSERT INTO ITN_ORPD(VendorName,VendorCode,Branch,ReferenceNo,Email,DocumentNo,Status,PostingDate,ContactPerson,DocumentOwner,TotalBeforeDiscount,DiscountPercent,Discount,TaxAmount,TotalAmount,Remarks,BaseEntry,CreatedDate,CreatedBy,DeletedFlag) VALUES('{objITN_ORPD.VendorName}','{objITN_ORPD.VendorCode}','{objITN_ORPD.Branch}','{objITN_ORPD.ReferenceNo}','{objITN_ORPD.Email}','{objITN_ORPD.DocumentNo}','{objITN_ORPD.Status}',{objITN_ORPD.PostingDate},'{objITN_ORPD.ContactPerson}','{objITN_ORPD.DocumentOwner}',{objITN_ORPD.TotalBeforeDiscount},{objITN_ORPD.DiscountPercent},{objITN_ORPD.Discount},{objITN_ORPD.TaxAmount},{objITN_ORPD.TotalAmount},'{objITN_ORPD.Remarks}','{objITN_ORPD.BaseEntry}',{DateTime.Now},'ADMIN','N')");
            if (insertdata > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_ORPD.ITN_RPD1)
                {
                    this.dbConnection.Execute($@"INSERT INTO ITN_RPD1(ITN_ORPDID,ItemDescription,ItemCode,Quantity,DamagedQuantity,UnitPrice,DiscountPercent,TaxCode,TotalAmount,TaxAmount,Warehouse,BaseLine,CreatedDate,CreatedBy,DeletedFlag,SERIAL_NO,BATCH_NO) VALUES({objITN_ORPD.Id},'{data.ItemDescription}','{data.ItemCode}',{data.Quantity},{data.DamagedQuantity},{data.UnitPrice},{data.DiscountPercent},'{data.TaxCode}',{data.TotalAmount},{data.TaxAmount},'{data.Warehouse}','{data.BaseLine}',{DateTime.Now},'ADMIN','N',{serialNo},{serialNo})");
                    serialNo++;
                }
                return true;
            }
            return false;
        }

        public bool UpdateStockReturn(ITN_ORPD objITN_ORPD)
        {
            int updateRows = this.dbConnection.Execute($@"UPDATE ITN_ORPD SET VendorName='{objITN_ORPD.VendorName}', VendorCode='{objITN_ORPD.VendorCode}' , Branch='{objITN_ORPD.Branch}',ReferenceNo='{objITN_ORPD.ReferenceNo}',Email='{objITN_ORPD.Email}',DocumentNo='{objITN_ORPD.DocumentNo}',Status='{objITN_ORPD.Status}',PostingDate={objITN_ORPD.PostingDate},ContactPerson={objITN_ORPD.ContactPerson},DocumentOwner='{objITN_ORPD.DocumentOwner}',TotalBeforeDiscount={objITN_ORPD.TotalBeforeDiscount},DiscountPercent={objITN_ORPD.DiscountPercent},Discount={objITN_ORPD.Discount},TaxAmount={objITN_ORPD.TaxAmount},TotalAmount={objITN_ORPD.TotalAmount},Remarks='{objITN_ORPD.Remarks}',,BaseEntry='{objITN_ORPD.BaseEntry}',UpdatedDate={DateTime.Now},UpdatedBy='ADMIN'");

            if (updateRows > 0)
            {
                int serialNo = 1;
                foreach (var data in objITN_ORPD.ITN_RPD1)
                {
                    this.dbConnection.Execute($@"UPDATE ITN_RPD1  SET ItemDescription='{data.ItemDescription}',ItemCode='{data.ItemCode}',Quantity={data.Quantity},DamagedQuantity={data.DamagedQuantity},UnitPrice={data.UnitPrice},DiscountPercent={data.DiscountPercent},TaxCode='{data.TaxCode}',TotalAmount={data.TotalAmount},TaxAmount={data.TotalAmount},Warehouse='{data.Warehouse}',BaseLine='{data.BaseLine}',UpadtedDate={DateTime.Now},UpdatedBy='ADMIN',DeletedFlag='N',SERIAL_NO={serialNo},BATCH_NO={serialNo}");
                    serialNo++;
                }
                return true;
            }
            return false;
        }
    }
}
