using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DSP.Domain.Models
{
    public class ITN_BVPM1
    {
        [Key]
        public int IncPayCId { get; set; }
        [Required]
        public int IncPayId { get; set; }
        [Required]
        [MaxLength(1)]
        public string Choose { get; set; }
        [Required]
        [MaxLength(20)]
        public string Invoice { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? PaidAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? BalanceAmount { get; set; }
        public int? SERIAL_NO { get; set; }
        public int? BATCH_NO { get; set; }
        public DateTime? CreatedDate { get; set; }
        [MaxLength(150)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(150)]
        public string UpdatedBy { get; set; }
        [MaxLength(1)]
        [DefaultValue("N")]
        public string DeletedFlag { get; set; }
        public ITN_BOVPM ITN_BOVPM { get; set; }
    }
}
