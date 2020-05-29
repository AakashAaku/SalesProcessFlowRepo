using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DSP.Core.Interfaces;
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
       

        // GET: /<controller>/
        public AdminController(RoleManager<IdentityRole> roleManager,IHostingEnvironment hostingEnvironment)
        {
            this._roleManager = roleManager;
            this._hostingEnvironment = hostingEnvironment;
           
        }


        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }


        [HttpGet]
        public IActionResult UserManager()
        {
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
            var dictionary = new Dictionary<string, string>();
            dictionary.Add("Admin", "12");
            dictionary.Add("Branch", "10");
            dictionary.Add("Depot", "7");

            ViewBag.License = dictionary;

            return View();
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
                int intbuffer = 5242880;
                byte[] b = new byte[intbuffer];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (fs.Read(b, 0, b.Length) > 0)
                {
                    result.AppendLine(temp.GetString(b));
                }

            }

            
            //var fileName = System.IO.Path.GetFileName(file.FileName);
            //if (System.IO.File.Exists(fileName))
            //{
            //    System.IO.File.Delete(fileName);
            //}

            //string fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

            //fileName = this.CheckCorrectFileName(fileName);

            //using (FileStream output = System.IO.File.Create(this.GetPathAndFileName(fileName))) await file.CopyToAsync(output);

            //var result = new StringBuilder();
            //using (var stremReader = new StreamReader(file.OpenReadStream()))
            //{
            //    while (stremReader.Peek() > 0)
            //    {
            //        result.AppendLine(await stremReader.ReadLineAsync());
            //    }
            //}

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
