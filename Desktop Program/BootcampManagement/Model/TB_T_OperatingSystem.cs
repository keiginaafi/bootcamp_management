﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_T_OperatingSystem : BaseModel
    {
        public virtual TB_M_OperatingSystem TB_M_OperatingSystems { get; set; }
        public virtual TB_T_CV TB_T_CVs { get; set; }
    }
}
