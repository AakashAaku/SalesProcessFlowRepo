﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DSP.Domain.Models
{
    public class ITN_OPRO
    {
        [Key]
      
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string VendorName { get; set; }
        [Required]
        [MaxLength(20)]
        public string VendorCode { get; set; }
        [Required]
        [MaxLength(30)]
        public string Branch { get; set; }

        [MaxLength(150)]
        public string ReferenceNo { get; set; }

        [Required]
        [MaxLength(20)]
        public string Email { get; set; }

        [Required]
        [MaxLength(4)]
        public string DocumentNo { get; set; }

      
        [MaxLength(20)]
        public string Status { get; set; }

        public DateTime? PostingDate { get; set; }

     
        [MaxLength(20)]
        public string ContactPerson { get; set; }

        [MaxLength(30)]
        public string DocumentOwner { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalBeforeDiscount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPercent { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TaxAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? TotalAmount { get; set; }

        [MaxLength(30)]
        public string Remarks { get; set; }

        public string PORefNo { get; set; }

        public string SORefNo { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string DeletedFlag { get; set; }


    }
}
