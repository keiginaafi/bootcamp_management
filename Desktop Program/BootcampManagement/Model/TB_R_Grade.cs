using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_R_Grade : BaseModel
    {
        public char Grade { get; set; }
        public virtual TB_M_BootcampMember TB_M_BootcampMembers { get; set;}
        public virtual TB_T_DailyScore TB_T_DailyScores { get; set; }
        public virtual TB_T_WeeklyScore TB_T_WeeklyScores { get; set; }

    }
}
