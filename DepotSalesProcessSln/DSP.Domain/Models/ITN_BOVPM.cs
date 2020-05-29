using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DSP.Domain.Models
{
    public class ITN_BOVPM
    {
        [Key]
        public int? IncPayId { get; set; }
        [Required]
        [MaxLength(200)]
        public string CustVenName { get; set; }
        [Required]
        [MaxLength(20)]
        public string CustVenCode { get; set; }
        [Required]
        [MaxLength(1)]
        public string CustVenFlag { get; set; }
        [Required]
        [MaxLength(20)]
        public string Branch { get; set; }
        [MaxLength(150)]
        public string RefernceNo { get; set; }
        [Required]
        [MaxLength(20)]
        public string Email { get; set; }
        [Required]
        [MaxLength(4)]
        public string DocumentNo { get; set; }
        [MaxLength(20)]
        public string Status { get; set; }
        public DateTime? PostingDate { get; set; }
        [MaxLength(1)]
        public string CreditCard { get; set; }
        [MaxLength(1)]
        public string Cash { get; set; }
        [MaxLength(1)]
        public string BankTransfer { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalAmount { get; set; }
        [MaxLength(20)]
        public string DocumnentOwner { get; set; }
        [MaxLength(200)]
        public string Remarks { get; set; }
        public DateTime? CreatedDate { get; set; }
        [MaxLength(150)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [MaxLength(150)]
        public string UpdatedBy { get; set; }
        [MaxLength(2)]
        public string DeletedFlag { get; set; }
        public ICollection<ITN_BVPM1> ITN_BVPM1 { get; set; }
    }
}
