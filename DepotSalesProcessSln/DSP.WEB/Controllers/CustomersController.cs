using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DSP.Core.DTO;
using DSP.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DSP.WEB.Controllers
{
    [Authorize(Roles ="Admin")]
    public class CustomersController : Controller
    {

        private IVendorCustomersService _customerService;

        public CustomersController(IVendorCustomersService customerService)
        {
            _customerService = customerService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            VendorCustomersDTO customerDto = _customerService.GetAllCustomer();
            return View(customerDto);
        }
    }
}
