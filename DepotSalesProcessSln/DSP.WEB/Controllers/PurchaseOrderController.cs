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
    public class PurchaseOrderController : Controller
    {
        private IPurchaseOrderService _PiurchaseOrderService;
        public PurchaseOrderController(IPurchaseOrderService iPurchaseOrderService)
        {
            _PiurchaseOrderService = iPurchaseOrderService;
        }
        public IActionResult GetPurchaseOrder(string id)
        {
            PurchaseOrderDTO objDTO = _PiurchaseOrderService.GetPurchaseOrder(id);
            return View(objDTO);
        }
        [HttpGet]
        public IActionResult SaveUpdatePurchaseOrder()
        {
            return View();
        }
        public IActionResult DeletePurchaseOrder(string id)
        {
            _PiurchaseOrderService.DeletePurchaseOrder(id);
            return View();
        }
        [HttpPost]
        public IActionResult SaveUpdatePurchaseOrder(ITN_BOPOR objiTN_BOVPM)
        {
            _PiurchaseOrderService.SaveUpdatePurchaseOrder(objiTN_BOVPM);
            return View();
        }
    }
}