using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSP.Domain.Models
{
    public class VendorCustomers
    {
        [Required]
        [MaxLength(20)]
        public string Type { get; set; }

        [Required]
        [MaxLength(20)]
        public string Code { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        public string Reference { get; set; }

        public string Group { get; set; }

        public string GroupCode { get; set; }

        public string ContactPerson { get; set; }

        public string Number { get; set; }

        public string Email { get; set; }

        public string PANVAT { get; set; }

        public string ContractNo { get; set; }

        public string EmailId { get; set; }

        public string ShipToAddress { get; set; }
        public string BillToAddress { get; set; }

        public string Remarks { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
    }
}
