using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_T_CV : BaseModel
    {
        public virtual TB_M_User TB_M_Users { get; set; }
    }
}
