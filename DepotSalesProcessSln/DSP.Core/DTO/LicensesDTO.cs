using DSP.Domain.Models;
using System.Collections.Generic;

namespace DSP.Core.DTO
{
    public class LicensesDTO
    {
        public Licenses License { get; set; }

        public IEnumerable<Licenses> Licenses { get; set; }

    }
}
