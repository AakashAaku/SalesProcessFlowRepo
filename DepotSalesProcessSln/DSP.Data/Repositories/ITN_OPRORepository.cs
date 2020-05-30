using Dapper;
using DSP.Data.Context;
using DSP.Domain.Interfaces;
using DSP.Domain.Interfaces.BaseInterface;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DSP.Data.Repositories
{
    public class ITN_OPRORepository : BaseRepository, IITN_OPRORepository
    {
        // This is default entity framework implementation for accessing data 
        private DSPMainDbContext _context;

        //This is for dapper implementation
        // protected IDbConnection _dbConnection;
        // protected  readonly string _connectionString = string.Empty;

        public ITN_OPRORepository(DSPMainDbContext dbContext)
        {
            //Entity injection
            _context = dbContext;

            //dapper implementaion
            //_connectionString = "Data Source=DSPMainDb;Initial Catalog=DataManagement;Integrated Security=True";
            //_dbConnection = new SqlConnection(_connectionString);
        }

        public bool DeleteStockTransferRequest(string Id)
        {

            int deletedRows = this.dbConnection.Execute("UPDATE ITN_OPRO SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where Id = @Id", new { Id = Id });
            if (deletedRows > 0)
            {
                int deletedRowsC = this.dbConnection.Execute("UPDATE ITN_PRO1 SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where ITN_OPDNID = @Id", new { Id = Id });
                if (deletedRowsC > 0)
                {
                    return true;
                }
            }
            return false;
        }

        //public bool DeleteStockTransferRequest(int Id)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<ITN_OPRO> GetAllStockTransferRequest()
        {
            return dbConnection.Query<ITN_OPRO>("SELECT * FROM ITN_OPRO");
        }

        public IEnumerable<ITN_OPRO>  GetStockTransferRequestById(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.dbConnection.Query<ITN_OPRO>("SELECT * FROM ITN_OPRO");
            }
            else
            {
                IEnumerable<ITN_OPRO> objEnum = this.dbConnection.Query<ITN_OPRO>("SELECT * FROM ITN_OPRO WHERE Id = @Id'", new {Id = id });
                if (objEnum != null)
                {
                    IEnumerable<ITN_PRO1> objEnumITN_PRO1 = this.dbConnection.Query<ITN_PRO1>("SELECT * FROM ITN_PRO1 WHERE Id = @Id'", new { Id = id });
                    if (objEnumITN_PRO1 != null)
                    {
                        foreach (var data in objEnum)
                        {
                            foreach (var datachild in objEnumITN_PRO1)
                            {
                                data.ITN_PRO1.Add(datachild);
                            }
                        }
                    }
                }
                return objEnum;
            }
        }

        public bool InsertStockTransferRequest(ITN_OPRO itn_opro)
        {
            int insertdata = this.dbConnection.Execute($@"INSERT INTO ITN_OPRO(VendorName,VendorCode,Branch,ReferenceNo,Email,DocumentNo,Status,PostingDate,ContactPerson,DocumentOwner,TotalBeforeDiscount,DiscountPercent,Discount,TaxAmount,TotalAmount,Remarks,PORefNo,SORefNo,CreatedDate,CreatedBy,DeletedFlag) VALUES('{itn_opro.VendorName}','{itn_opro.VendorCode}','{itn_opro.Branch}','{itn_opro.ReferenceNo}','{itn_opro.Email}','{itn_opro.DocumentNo}','{itn_opro.Status}',{itn_opro.PostingDate},'{itn_opro.ContactPerson}','{itn_opro.DocumentOwner}',{itn_opro.TotalBeforeDiscount},{itn_opro.DiscountPercent},{itn_opro.Discount},{itn_opro.TaxAmount},{itn_opro.TotalAmount},'{itn_opro.Remarks}','{itn_opro.PORefNo}','{itn_opro.SORefNo}',{DateTime.Now},'ADMIN','N')");
                if (insertdata > 0)
                {
                    int serialNo = 1;
                    foreach (var data in itn_opro.ITN_PRO1)
                    {
                        this.dbConnection.Execute($@"INSERT INTO ITN_PRO1(ITN_PROID,ItemDescription,ItemCode,Quantity,ReceivedQty,UnitPrice,DiscountPercent,TaxCode,TotalAmount,TaxAmount,Warehouse,CreatedDate,CreatedBy,DeletedFlag,SERIAL_NO,BATCH_NO) VALUES({itn_opro.Id},'{data.ItemDescription}','{data.ItemCode}',{data.Quantity},{data.ReceivedQty},{data.UnitPrice},{data.DiscountPercent},'{data.TaxCode}',{data.TotalAmount},{data.TaxAmount},'{data.Warehouse}',{DateTime.Now},'ADMIN','N',{serialNo},{serialNo})");
                        serialNo++;
                    }
                    return true;
                }
                return false;         
        }

        public bool UpdateStockTransferRequest(ITN_OPRO itn_opro)
        {
            int updateRows = this.dbConnection.Execute($@"UPDATE ITN_OPRO SET VendorName='{itn_opro.VendorName}', VendorCode='{itn_opro.VendorCode}' , Branch='{itn_opro.Branch}',ReferenceNo='{itn_opro.ReferenceNo}',Email='{itn_opro.Email}',DocumentNo='{itn_opro.DocumentNo}',Status='{itn_opro.Status}',PostingDate={itn_opro.PostingDate},ContactPerson={itn_opro.ContactPerson},DocumentOwner='{itn_opro.DocumentOwner}',TotalBeforeDiscount={itn_opro.TotalBeforeDiscount},DiscountPercent={itn_opro.DiscountPercent},Discount={itn_opro.Discount},TaxAmount={itn_opro.TaxAmount},TotalAmount={itn_opro.TotalAmount},Remarks='{itn_opro.Remarks}',PORefNo='{itn_opro.PORefNo}',SORefNo='{itn_opro.SORefNo}',UpdatedDate={DateTime.Now},UpdatedBy='ADMIN'");

            if (updateRows > 0)
            {
                int serialNo = 1;
                foreach (var data in itn_opro.ITN_PRO1)
                {
                    this.dbConnection.Execute($@"UPDATE ITN_PRO1 SET ItemDescription='{data.ItemDescription}',ItemCode='{data.ItemCode}',Quantity={data.Quantity},ReceivedQty={data.ReceivedQty},UnitPrice={data.UnitPrice},DiscountPercent={data.DiscountPercent},TaxCode='{data.TaxCode}',TotalAmount={data.TotalAmount},TaxAmount={data.TotalAmount},Warehouse='{data.Warehouse}',UpadtedDate={DateTime.Now},UpdatedBy='ADMIN',DeletedFlag='N',SERIAL_NO={serialNo},BATCH_NO={serialNo}");
                    serialNo++;
                }
                return true;
            }
            return false;

        }
    }
}
