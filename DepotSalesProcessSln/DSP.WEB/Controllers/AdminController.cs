using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DSP.Core.DTO;
using DSP.Core.DTO.AppUser;
using DSP.Core.Interfaces;
using DSP.Core.Interfaces.AppUser;
using DSP.WEB.Data;
using DSP.WEB.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DSP.WEB.Controllers
{
   // [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly ILicenseService _licenseService;
        private IVendorCustomersService _vendorCustomerService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IAppUsersService _appUsersService;


        // GET: /<controller>/
        public AdminController(RoleManager<IdentityRole> roleManager,IHostingEnvironment hostingEnvironment, UserManager<ApplicationUser> userManager)
        {
            this._roleManager = roleManager;
            this._hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
            // this._licenseService = licenseService;
            //this._vendorCustomerService = vendorCustomersService;
        }


        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }


        [HttpGet]
        public IActionResult UserManager()
        {
            //var vendorList = _vendorCustomerService.GetAllCustomer();
            var vendorList1 = new List<VendorCustomersDTO>();
            vendorList1.Insert(0, new VendorCustomersDTO { Id = 0, Name = "Select Vendor/Customer" });
            vendorList1.Add(new VendorCustomersDTO { Id = 1, Name = "text1" });
            vendorList1.Add(new VendorCustomersDTO { Id = 2, Name = "text2" });
            vendorList1.Add(new VendorCustomersDTO { Id = 3, Name = "text3" });
            vendorList1.Add(new VendorCustomersDTO { Id = 4, Name = "text4" });
            ViewBag.VendorCustomerList = vendorList1;


            //var licenseList = _licenseService.GetAllLicense();
            var licenseList = new List<LicensesDTO>();
            licenseList.Insert(0, new LicensesDTO { Id = 0, Name = "Select License" });
            licenseList.Add(new LicensesDTO { Id = 1, Name = "text1" });
            licenseList.Add(new LicensesDTO { Id = 2, Name = "text2" });
            licenseList.Add(new LicensesDTO { Id = 3, Name = "text3" });
            licenseList.Add(new LicensesDTO { Id = 4, Name = "text4" });
            ViewBag.LicenseAssignList = licenseList;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UserManager(AppUsersDTO userModal)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = userModal.AppUser.UserName, Email = userModal.AppUser.EmailAddress };
                var result = await _userManager.CreateAsync(user, userModal.AppUser.Password);
                if (result.Succeeded)
                {
                    _appUsersService.SaveAppUser(userModal);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult CreateVendorCustomer()
        {

           
            //vendorList.Customers.ElementAtOrDefault(0)

           
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleViewModel modal)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = modal.Name
                };

                IdentityResult result = await _roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("CreateRole", "Admin");
                }
                foreach(IdentityError err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return View(modal);
        }

        [HttpGet]
        public IActionResult CreateLicense() 
        {
           
            var model = _licenseService.GetAllLicense();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> CreateLicense(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                ViewBag.ErroMessage = "File Not Selected";
                return View();
            }

            string rootPath = this._hostingEnvironment.ContentRootPath;

            string path = Path.Combine(this._hostingEnvironment.WebRootPath, "UploadedFile");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }


            string fileName = Path.GetFileName(file.FileName);
            string fileExt = Path.GetExtension(fileName);
            var result = new StringBuilder();
            using (FileStream fs = new FileStream(Path.Combine(path, fileName), FileMode.OpenOrCreate))
            {
                if (System.IO.File.Exists(path + "\\" + fileName))
                {
                    System.IO.File.Delete(fileName);
                }
                await file.CopyToAsync(fs);
            }

            var fileToRead = path + "\\" + Path.GetFileName(file.FileName);
            string fileContext = await System.IO.File.ReadAllTextAsync(fileToRead);
            var licenseModel = new List<LicensesDTO>();
            if (fileExt == ".txt")
            {
                foreach (var row in fileContext.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                       
                        var modelData = new LicensesDTO
                        {
                            Id= Convert.ToInt32(row.Split('\t')[0]),
                            Name= row.Split('\t')[0],
                            LicenseVal= Convert.ToByte(row.Split('\t')[0])
                        };
                        licenseModel.Add(modelData);
                    }
                }
            }
            if (fileExt == ".csv")
            {
                foreach (var row in fileContext.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(row))
                    {
                       
                        var modelData = new LicensesDTO
                        {
                            Id = Convert.ToInt32(row.Split(',')[0]),
                            Name = row.Split(',')[0],
                            LicenseVal = Convert.ToByte(row.Split(',')[0])
                        };
                        licenseModel.Add(modelData);
                    }
                }
            }

            var licenseSavedResponse = _licenseService.SaveLicence(licenseModel); 

            

            ViewBag.SuccessMessage = "File Uploaded Successfully";
            return View();
        }

        private string CheckCorrectFileName(string file)
        {
            if (file.Contains("\\")) file = file.Substring(file.LastIndexOf("\\") + 1);

            return file;
        }

        private string GetPathAndFileName(string fileName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "\\uploads\\" + fileName);
        }


       
        public IActionResult Index()
        {
            IEnumerable<IdentityRole> roleResult = _roleManager.Roles.ToList();
            var roleList = new List<RoleViewModel>();
            foreach(var role in roleResult)
            {
                var roleL = new RoleViewModel
                {
                    Name = role.Name
                };
                roleList.Add(roleL);
            }
            return View(roleList);
        }
    }
}
