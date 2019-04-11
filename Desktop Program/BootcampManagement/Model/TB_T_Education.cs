using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_T_Education : BaseModel
    {
        public string Graduation_Year { get; set; }
        public decimal GPA { get; set; }
        public virtual TB_M_Major TB_M_Majors { get; set; }
        public virtual TB_T_CV TB_T_CVs { get; set; }
    }
}
