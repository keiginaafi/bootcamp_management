﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_T_WorkAssignment : BaseModel
    {
        public string Job_desk { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public virtual TB_M_WorkAssignment TB_M_WorkAssignments { get; set; }
        public virtual TB_T_CV TB_T_CVs { get; set; }
    }
}
