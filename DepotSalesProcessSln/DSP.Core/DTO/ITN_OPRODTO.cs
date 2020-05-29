using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DSP.Core.DTO
{
    public class ITN_OPRODTO
    {
        public ITN_OPRO ITN_OPRO { get; set; }
        public IEnumerable<ITN_OPRO> ITN_OPROs { get; set; }
        
    }
   
}
