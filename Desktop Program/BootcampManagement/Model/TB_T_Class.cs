using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_T_Class : BaseModel
    {
        public virtual TB_M_Batch TB_M_Batchs { get; set; }
        public virtual TB_M_Trainer TB_M_Trainers { get; set; }
        public virtual TB_M_Room TB_M_Rooms { get; set; }
        public virtual TB_M_Class TB_M_Classs { get; set; }
        public virtual TB_M_BootcampMember TB_M_BootcampMembers { get; set; } 
    }
}
