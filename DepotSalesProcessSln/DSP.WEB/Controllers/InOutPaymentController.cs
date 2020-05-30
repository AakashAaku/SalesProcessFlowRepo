using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSP.Core.DTO;
using DSP.Core.Interfaces;
using DSP.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DSP.WEB.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InOutPaymentController : Controller
    {
        private IInOutPaymentService _iInOutPaymentService;
        public InOutPaymentController(IInOutPaymentService iInOutPaymentService)
        {
            _iInOutPaymentService = iInOutPaymentService;
        }
        public IActionResult GetInOutPayment(string id)
        {
            InOutPaymentDTO objDTO = _iInOutPaymentService.GetInOutPayment(id);
            return View(objDTO);
        }
        [HttpGet]
        public IActionResult SaveUpdateIncomingPayment()
        {            
            return View();
        }
        public IActionResult DeleteInOutPayment(string id)
        {
             _iInOutPaymentService.DeleteInOutPayment(id);
            return View();
        }
        [HttpPost]
        public IActionResult SaveUpdateIncomingPayment(ITN_BOVPM objiTN_BOVPM)
        {
            _iInOutPaymentService.SaveUpdateIncomingPayment(objiTN_BOVPM);
            return View();
        }

    }
}