using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DSP.Domain.Models
{
    public class Licenses
    {
        [Key,ForeignKey("AppUser")]
        public int LicensesId { get; set; } 

        [Required]
        public string Type { get; set; }

        [Required]
        public byte License { get; set; }

        
    }
}
