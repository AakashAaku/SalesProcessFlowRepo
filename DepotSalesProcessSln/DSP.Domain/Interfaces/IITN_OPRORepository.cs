using DSP.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSP.Domain.Interfaces
{
   public interface IITN_OPRORepository
    {
        IEnumerable<ITN_OPRO> GetAllITN_OPRO();
        ITN_OPRO GetITN_OPROById(int id);
        
        void InsertITN_OPRO(ITN_OPRO itn_opro);
        void DeleteITN_OPRO(int bookId);
        void UpdateITN_OPRO(ITN_OPRO itn_opro);
    }
}
