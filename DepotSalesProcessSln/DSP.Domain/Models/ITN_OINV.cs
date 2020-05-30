using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
namespace DSP.Domain.Models
{
    public class ITN_OINV
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Invoice Type")]
        
        [MaxLength(20)]
        public string InvoiceType { get; set; }
        [DisplayName("PAN/VAT/Number")]
      
        [MaxLength(20)]
        public string PANVATNumber { get; set; }
        [DisplayName("Customer Name")]
        [Required]
        [MaxLength(200)]
        public string CustomerName { get; set; }
        [DisplayName("Customer Code")]
        [Required]
        [MaxLength(20)]
        public string CustomerCode { get; set; }
        [DisplayName("Branch")]
        [Required]
        [MaxLength(30)]
        public string Branch { get; set; }
        [DisplayName("Reference No.")]
        [MaxLength(20)]
        public string ReferenceNo { get; set; }
        [DisplayName("Email")]
        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
        [DisplayName("Document No")]
        [Required]
        [MaxLength(4)]
        public string DocumentNo { get; set; }
        [DisplayName("Status")]
        [MaxLength(20)]
        public string Status { get; set; }
        [DisplayName("Posting Date")]
        public DateTime? Postingdate { get; set; }
        [DisplayName("Contact Person")]
        [MaxLength(20)]
        public string ContactPerson { get; set; }
        [DisplayName("Document Owner")]
        [MaxLength(30)]
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

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Amount Paid")]
        public decimal? AmountPaid { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Amount Retuen")]
        public decimal? AmountReturn { get; set; }

        public DateTime CreatedDate { get; set; }
        [MaxLength(150)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        [MaxLength(150)]
        public string UpdatedBy { get; set; }
        [MaxLength(2)]
        public string DeletedFlag { get; set; }

        public ICollection<ITN_INV1> ITN_INV1 { get; set; }
    }
}
