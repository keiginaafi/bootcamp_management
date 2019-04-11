using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_BootcampMember : BaseModel
    {
        public DateTime Join_date { get; set; }
        public DateTime Last_date { get; set; }
        public char status { get; set; }
        public virtual TB_M_User TB_M_Users { get; set; }
        public virtual TB_M_AccessCard TB_M_AccessCards { get; set; }
        public virtual TB_M_Locker TB_M_Lockers { get; set; }
        public virtual TB_T_CV TB_T_CVs { get; set; }
    }
}
