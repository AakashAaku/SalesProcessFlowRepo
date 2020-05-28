using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSP.Core.DTO
{
    public class ITN_OPRODTO
    {
        public int Id { get; set; }
        //public IEnumerable<ITN_OPRO> ITN_OPRO { get; set; }
        [Display(Name = "Vendor Name")]
        public string VendorName { get; set; }
        [Display(Name = "Vendor Code")]
        public string VendorCode { get; set; }
        public string Branch { get; set; }
        [Display(Name = "Reference No")]
        public string ReferenceNo { get; set; }
        public string Email { get; set; }
        [Display(Name = "Document No")]
        public string DocumentNo { get; set; }
        public string Status { get; set; }
        [Display(Name = "Posting Date")]
        public DateTime? PostingDate { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Display(Name = "Document Owner")]
        public string DocumentOwner { get; set; }
        [Display(Name = "Total Before Discount")]
        public decimal? TotalBeforeDiscount { get; set; }
        [Display(Name = "Discount Percent")]
        public decimal? DiscountPercent { get; set; }
        public decimal? Discount { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal? TaxAmount { get; set; }
        [Display(Name = "Total Amount")]
        public decimal? TotalAmount { get; set; }
        public string Remarks { get; set; }
        public string PORefNo { get; set; }
        public string SORefNo { get; set; }
        public List<ITN_PRO1> ITN_PRO1DTOList { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public string CreatedBy { get; set; }
        //public DateTime? UpdatedDate { get; set; }
        //public string UpdatedBy { get; set; }
        //public string DeletedFlag { get; set; }
    }
    public class ITN_PRO1DTO
    {

        public int Id { get; set; }

        public int ITN_PROID { get; set; }
        [Display(Name = "Item Description")]
        public string ItemDescription { get; set; }
        [Display(Name = "Item Code")]
        public string ItemCode { get; set; }


        public decimal Quantity { get; set; }
        [Display(Name = "Received Quantity")]
        public decimal? ReceivedQty { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Discount Percent")]
        public decimal DiscountPercent { get; set; }
        [Display(Name = "Tax Code")]
        public string TaxCode { get; set; }
        [Display(Name = "Total Amount")]
        public decimal TotalAmount { get; set; }
        [Display(Name = "Tax Amount")]
        public decimal? TaxAmount { get; set; }

        [Display(Name = "Ware house")]
        public string Warehouse { get; set; }

        //public DateTime CreatedDate { get; set; }
        //[Required]
        //[MaxLength(150)]
        //public string CreatedBy { get; set; }

        //public DateTime? UpdatedDate { get; set; }
        //[MaxLength(150)]
        //public string UpdatedBy { get; set; }
        //[MaxLength(2)]
        //public string DeletedFlag { get; set; }

        public int SERIAL_NO { get; set; }

        public int? BATCH_NO { get; set; }

        public ITN_OPRO ITN_OPRO { get; set; }
    }
}
