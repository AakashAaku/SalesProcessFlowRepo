using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DSP.Domain.Models
{
    public class ITN_PRO1
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ITN_PROID { get; set; }
        [Required]
        [MaxLength(200)]
        public string ItemDescription { get; set; }
        [Required]
        [MaxLength(20)]
        public string ItemCode { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Quantity { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? ReceivedQty { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal UnitPrice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal DiscountPercent { get; set; }
        [Required]
        [MaxLength(10)]
        public string TaxCode { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal TotalAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TaxAmount { get; set; }

        [Required]
        [MaxLength(20)]
        public string Warehouse { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string DeletedFlag { get; set; }

        public int SERIAL_NO { get; set; }

        public int? BATCH_NO { get; set; }
    }
}
