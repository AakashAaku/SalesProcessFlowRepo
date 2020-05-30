using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DSP.Domain.Models
{
   public class ITN_ORPD
    {
        [Key]

        public int Id { get; set; }
        [DisplayName("Vendor Name")]
        [Required]
        [MaxLength(200)]
        public string VendorName { get; set; }
        [DisplayName("Vendor Code")]
        [Required]
        [MaxLength(20)]
        public string VendorCode { get; set; }
        [Required]
        [MaxLength(30)]
        public string Branch { get; set; }
        [DisplayName("Reference No")]
        [MaxLength(150)]
        public string ReferenceNo { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
        [DisplayName("Document No")]
        [Required]
        [MaxLength(4)]
        public string DocumentNo { get; set; }


        [MaxLength(20)]
        public string Status { get; set; }
        [DisplayName("Posting Date")]
        public DateTime? PostingDate { get; set; }


        [MaxLength(20)]
        [DisplayName("Contact Person")]
        public string ContactPerson { get; set; }

        [MaxLength(30)]
        [DisplayName("Document Owner")]
        public string DocumentOwner { get; set; }
        [DisplayName("Total Before Discount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalBeforeDiscount { get; set; }
        [DisplayName("Discount Percent")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPercent { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Tax Amount")]
        public decimal? TaxAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Total Amount")]
        public decimal? TotalAmount { get; set; }

        [MaxLength(30)]
        public string Remarks { get; set; }
        [DisplayName("Base Entry")]
        [MaxLength(30)]
        public string BaseEntry { get; set; }

        public DateTime CreatedDate { get; set; }
        [MaxLength(150)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        [MaxLength(150)]
        public string UpdatedBy { get; set; }
        [MaxLength(2)]
        public string DeletedFlag { get; set; }

        public ICollection<ITN_RPD1> ITN_RPD1 { get; set; }

    }
}
