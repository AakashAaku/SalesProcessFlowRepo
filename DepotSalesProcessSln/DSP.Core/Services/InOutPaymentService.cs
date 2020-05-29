using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Interfaces;
using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Core.Services
{
    public class InOutPaymentService: IInOutPaymentService
    {
        public IInOutPaymentRepository _iinOutPaymentRepository;
        public InOutPaymentService(IInOutPaymentRepository iinOutPaymentRepository)
        {
            _iinOutPaymentRepository = iinOutPaymentRepository;
        }
        public InOutPaymentDTO GetInOutPayment(string id)
        {
            return new InOutPaymentDTO
            {
                InOutPayment = _iinOutPaymentRepository.GetInOutPayment(id)
            };
        }
        public bool DeleteInOutPayment(string id)
        {
            return _iinOutPaymentRepository.DeleteInOutPayment(id);
        }
        public bool SaveUpdateIncomingPayment(ITN_BOVPM objiTN_BOVPM)
        {
            return _iinOutPaymentRepository.SaveUpdateIncomingPayment(objiTN_BOVPM);
        }
    }
}
