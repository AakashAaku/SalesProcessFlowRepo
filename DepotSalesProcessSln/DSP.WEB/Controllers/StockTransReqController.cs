using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSP.Core.DTO;
using DSP.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DSP.WEB.Controllers
{
    public class StockTransReqController : Controller
    {
       private IITN_OPROService _oproService;

        public StockTransReqController(IITN_OPROService oproService)
        {
            _oproService = oproService;
        }


        public IActionResult Index()
        {
            ITN_OPRODTO oproDto = _oproService.GetAllStockTransferReq();
            return View(oproDto);
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
    }
}