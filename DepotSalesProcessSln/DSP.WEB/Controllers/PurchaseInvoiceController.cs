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
    public class PurchaseInvoiceController : Controller
    {
        private IPurchaseInvoiceService _iPurchaseInvoiceService;
        public PurchaseInvoiceController(IPurchaseInvoiceService iPurchaseInvoiceService)
        {
            _iPurchaseInvoiceService = iPurchaseInvoiceService;
        }
        public IActionResult GetPurchaseInvoice(string id)
        {
            PurchaseInvoiceDTO objDTO = _iPurchaseInvoiceService.GetPurchaseInvoice(id);
            return View(objDTO);
        }
        [HttpGet]
        public IActionResult SaveUpdatePurchaseInvoice()
        {
            return View();
        }
        public IActionResult DeletePurchaseInvoice(string id)
        {
            _iPurchaseInvoiceService.DeletePurchaseInvoice(id);
            return View();
        }
        [HttpPost]
        public IActionResult SaveUpdatePurchaseInvoice(ITN_BOPCH objiTN_BOVPM)
        {
            _iPurchaseInvoiceService.SaveUpdatePurchaseInvoice(objiTN_BOVPM);
            return View();
        }
    }
}