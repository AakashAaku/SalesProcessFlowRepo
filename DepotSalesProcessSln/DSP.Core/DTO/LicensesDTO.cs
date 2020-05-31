using DSP.Domain.Models;
using System.Collections.Generic;

namespace DSP.Core.DTO
{
    public class LicensesDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public byte LicenseVal { get; set; } 

        public Licenses License { get; set; }

        public IEnumerable<Licenses> Licenses { get; set; }

    }
}
