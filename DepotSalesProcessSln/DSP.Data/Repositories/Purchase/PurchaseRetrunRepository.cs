using Dapper;
using DSP.Data.Context;
using DSP.Domain.Interfaces.Purchase;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Data.Repositories
{
    public class PurchaseRetrunRepository : BaseRepository, IPurchaseReturnRepository
    {
        private DSPMainDbContext _context;
        public PurchaseRetrunRepository(DSPMainDbContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<ITN_BORPD> GetPurchaseReturn(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return this.dbConnection.Query<ITN_BORPD>("SELECT * FROM ITN_BORPD");
            }
            else
            {
                IEnumerable<ITN_BORPD> objEnum = this.dbConnection.Query<ITN_BORPD>("SELECT * FROM ITN_BORPD WHERE IncPayId = @IncPayId'", new { IncPayId = id });
                if (objEnum != null)
                {
                    IEnumerable<ITN_BRPD1> objEnumITN_BVPM1 = this.dbConnection.Query<ITN_BRPD1>("SELECT * FROM ITN_BVPM1 WHERE IncPayCId = @IncPayCId'", new { IncPayCId = id });
                    if (objEnumITN_BVPM1 != null)
                    {
                        foreach (var data in objEnum)
                        {
                            foreach (var datachild in objEnumITN_BVPM1)
                            {
                                data.ITN_BRPD1.Add(datachild);
                            }
                        }
                    }
                }
                return objEnum;
            }
        }
        public bool DeletePurchaseReturn(string id)
        {
            int deletedRows = this.dbConnection.Execute("UPDATE ITN_B0RPD SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where IncPayId = @IncPayId", new { IncPayId = id });
            if (deletedRows > 0)
            {
                int deletedRowsC = this.dbConnection.Execute("UPDATE ITN_BRPD1 SET DeletedFlag = 'N',UpdatedBy ='ADMIN',UpdatedDate =GETDATE() where IncPayId = @IncPayId", new { IncPayId = id });
                if (deletedRowsC > 0)
                {
                    return true;
                }
            }
            return false;
        }
        public bool SaveUpdatePurchaseReturn(ITN_BORPD objiTN_BOVPM)
        {
            if (objiTN_BOVPM.PRId == null)
            {
                int insertedRows = this.dbConnection.Execute(@"INSERT INTO ITN_BOVPM(CustVenName,CustVenCode,CustVenFlag,Branch,RefernceNo,Email,DocumentNo,Status,PostingDate,CreditCard,Cash,BankTransfer,TotalAmount,DocumnentOwner,Remarks,CreatedDate,CreatedBy) VALUES(@CustVenName,@CustVenCode,@CustVenFlag,@Branch,@RefernceNo,@Email,@DocumentNo,@Status,GETDATE(),@CreditCard,@Cash,@BankTransfer,@TotalAmount,@DocumnentOwner,@Remarks,GETDATE(),@CreatedBy)", new { objiTN_BOVPM.VendorName, objiTN_BOVPM.VendorCode,objiTN_BOVPM.Branch, objiTN_BOVPM.RefernceNo, objiTN_BOVPM.Email, objiTN_BOVPM.DocumentNo, objiTN_BOVPM.Status, objiTN_BOVPM.TotalAmount, objiTN_BOVPM.DocumnentOwner, objiTN_BOVPM.Remarks, objiTN_BOVPM.CreatedBy });
                if (insertedRows > 0)
                {
                    int serialNo = 1;
                    foreach (var data in objiTN_BOVPM.ITN_BRPD1)
                    {
                        this.dbConnection.Execute(@"INSERT INTO ITN_BVPM1(IncPayId,Choose,Invoice,TotalAmount,PaidAmount,BalanceAmount,SERIAL_NO,BATCH_NO,CreatedDate,CreatedBy) VALUES(@IncPayId,@Choose,@Invoice,@TotalAmount,@PaidAmount,@BalanceAmount,@SERIAL_NO,@BATCH_NO,GETDATE(),@CreatedBy)", new { data.PRCId,data.TotalAmount,serialNo, data.BATCH_NO, data.CreatedBy });
                        serialNo++;
                    }
                    return true;
                }
                return false;
            }
            else
            {
                int updateRows = this.dbConnection.Execute(@"UPDATE ITN_BOVPM SET CustVenName=@CustVenName,CustVenCode=@CustVenCode,CustVenFlag=@CustVenFlag,Branch=@Branch,RefernceNo=@RefernceNo,Email=@Email,DocumentNo=@DocumentNo,Status=@Status,PostingDate=@PostingDate,CreditCard=@CreditCard,Cash=@Cash,BankTransfer=@BankTransfer,TotalAmount=@TotalAmount,DocumnentOwner=@DocumnentOwner,Remarks=@Remarks,UpdatedDate=GET,UpdatedBy=@UpdatedBy", new { objiTN_BOVPM.VendorName, objiTN_BOVPM.VendorCode, objiTN_BOVPM.Branch, objiTN_BOVPM.RefernceNo, objiTN_BOVPM.Email, objiTN_BOVPM.DocumentNo, objiTN_BOVPM.Status, objiTN_BOVPM.TotalAmount, objiTN_BOVPM.DocumnentOwner, objiTN_BOVPM.Remarks, objiTN_BOVPM.CreatedBy });
                if (updateRows > 0)
                {
                    int serialNo = 1;
                    foreach (var data in objiTN_BOVPM.ITN_BRPD1)
                    {
                        this.dbConnection.Execute(@"UPDATE ITN_BVPM1 SET IncPayId=@IncPayId,Choose=@Choose,Invoice=@Invoice,TotalAmount=@TotalAmount,PaidAmount=@PaidAmount,BalanceAmount=@BalanceAmount,SERIAL_NO=@SERIAL_NO,BATCH_NO=@BATCH_NO,UpdatedDate=GET,UpdatedBy=@UpdatedBy WHERE IncPayCId= @IncPayCId", new { data.PRCId, data.TotalAmount, serialNo, data.BATCH_NO, data.CreatedBy });
                        serialNo++;
                    }
                    return true;
                }
                return false;
            }
        }
    }
}
