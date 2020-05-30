using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSP.Core.DTO;
using DSP.Core.Interfaces.Purchase;
using DSP.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace DSP.WEB.Controllers
{
    public class PurchaseReturnController : Controller
    {
        private IPurchaseReturnService _iPurchaseReturnService;
        public PurchaseReturnController(IPurchaseReturnService iPurchaseReturnService)
        {
            _iPurchaseReturnService = iPurchaseReturnService;
        }
        public IActionResult GetPurchaseReturn(string id)
        {
            PurchseReturnDTO objDTO = _iPurchaseReturnService.GetPurchaseReturn(id);
            return View(objDTO);
        }
        [HttpGet]
        public IActionResult SaveUpdatePurchaseReturn()
        {
            return View();
        }
        public IActionResult DeletePurchaseReturn(string id)
        {
            _iPurchaseReturnService.DeletePurchaseReturn(id);
            return View();
        }
        [HttpPost]
        public IActionResult SaveUpdatePurchaseInvoice(ITN_BORPD objiTN_BOVPM)
        {
            _iPurchaseReturnService.SaveUpdatePurchaseReturn(objiTN_BOVPM);
            return View();
        }
    }
}