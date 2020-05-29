using DSP.Domain.DomainEnum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DSP.Domain.Models
{
    public class VendorsCustomer
    {
        [Key,ForeignKey("AppUsers")]
        public int VendorCustomerId { get; set; }

        [Required]
        public UserType Type { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }

        public string Reference { get; set; }

        [Required]
        public string Group { get; set; }

        [Required]
        public string GroupCode { get; set; }

        public string ContactPerson { get; set; }

        public string ContactNumber { get; set; }

        public string Email { get; set; }

        public string PANVAT { get; set; }

        [Required]
        public string ContractNo { get; set; }

        public string EmailId { get; set; }

        public string ShipToAddress { get; set; }

        public string BillToAddress { get; set; }

        public string Remarks { get; set; }

        


    }
}
