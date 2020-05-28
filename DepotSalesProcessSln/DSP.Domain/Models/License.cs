using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSP.Domain.Models
{
    public class Licenses
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public byte License { get; set; }
    }
}
