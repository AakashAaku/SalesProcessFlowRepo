using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace DSP.Domain.Models
{
   public class ITN_INV1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ITN_OINVID { get; set; }
        [DisplayName("Item Description")]
        [Required]
        [MaxLength(200)]
        public string ItemDescription { get; set; }
        [DisplayName("Item Code")]
        [Required]
        [MaxLength(20)]
        public string ItemCode { get; set; }
        [Required]
        [DisplayName("Quantity")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Quantity { get; set; }
      

        [Column(TypeName = "decimal(18,2)")]
        [DisplayName("Unit Price")]
        [Required]
        public decimal UnitPrice { get; set; }
        [DisplayName("Discount%")]
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal DiscountPercent { get; set; }
        [DisplayName("Tax Code")]
        [Required]
        [MaxLength(10)]
        public string TaxCode { get; set; }
        [DisplayName("Total Amount")]
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal TotalAmount { get; set; }
        [DisplayName("Tax Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TaxAmount { get; set; }

        [Required]
        [MaxLength(20)]
        public string Warehouse { get; set; }
        [DisplayName("Base Quantity")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? BaseQuantity { get; set; }

        [DisplayName("Base Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal? BaseAmount { get; set; }
        public DateTime CreatedDate { get; set; }
        [Required]
        [MaxLength(150)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
        [MaxLength(150)]
        public string UpdatedBy { get; set; }
        [MaxLength(2)]
        public string DeletedFlag { get; set; }

        public int SERIAL_NO { get; set; }

        public int? BATCH_NO { get; set; }

        public ITN_OINV ITN_OINV { get; set; }
    }
}
