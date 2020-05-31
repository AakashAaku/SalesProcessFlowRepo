using DSP.Domain.DomainEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSP.Domain.Models
{
    public class DspUsers
    {
        [Key]
        public int DspUsersId { get; set; }

        [Required]
        public UserType Type { get; set; }
       
        
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string SAPBranch { get; set; }

        [Required]
        public string BranchCode { get; set; }

        [Required]
        public string Warehouse { get; set; }

        [Required]
        public string WarehouseCode { get; set; }

        //[Required]
        //public VendorsCustomer Customer { get; set; }

        [Required]
        public string CustomerCode { get; set; }

        [Required]
        public VendorsCustomer VendorCustomer { get; set; }

        [Required]
        public string VendorCode { get; set; }

        public string ContactNo { get; set; }

        public string EmailAddress { get; set; }

        public Licenses LicenseAssign { get; set; }

        public string LicenseAvailablity { get; set; }

        public string Active { get; set; }

        public string Approver { get; set; }
    }
}
