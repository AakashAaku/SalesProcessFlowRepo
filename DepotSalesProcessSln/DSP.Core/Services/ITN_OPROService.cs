using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class ITN_OPROService: IITN_OPROService
    {
        public IITN_OPRORepository _itnRepository;

        public ITN_OPROService(IITN_OPRORepository itnRepository)
        {
            _itnRepository = itnRepository;
        }

        public bool DeleteStockTransferRequest(string id)
        {
            return _itnRepository.DeleteStockTransferRequest(id);
        }

        public ITN_OPRODTO GetAllStockTransferReq()
        {

            try
            {
                return new ITN_OPRODTO
                {
                    ITN_OPROs = _itnRepository.GetAllStockTransferRequest()
                };

            }
            catch (Exception ex)
            {

                throw new Exception("Error while inserting data : " + ex.StackTrace);
            }
            
        }
        public ITN_OPRODTO GetStockTransferRequestById(string id)
        {

            try
            {
                return new ITN_OPRODTO
                {
                    ITN_OPROs = _itnRepository.GetStockTransferRequestById(id)
                };

            }
            catch (Exception ex)
            {

                throw new Exception("Error while getting data : " + ex.StackTrace);
            }

        }

        public bool SaveStockTransferReq(ITN_OPRODTO str)
        {
            try
            {
                var result = _itnRepository.InsertStockTransferRequest(str.ITN_OPRO);
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Error while getting data : " + ex.StackTrace);
            }
        }

        public bool UpdateStockTransferReq(ITN_OPRODTO str)
        {
            try
            {
                var result = _itnRepository.UpdateStockTransferRequest(str.ITN_OPRO);
                return result;
            }
            catch (Exception ex)
            {

                throw new Exception("Error while update data : " + ex.StackTrace);
            }
        }
    }
}
