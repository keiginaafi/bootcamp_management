using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_T_ProgrammingLanguage : BaseModel
    {
        public virtual TB_M_ProgrammingLanguage TB_M_ProgrammingLanguages { get; set; }
        public virtual TB_T_CV TB_T_Cvs { get; set; }
    }
}
