using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_Trainer : BaseModel
    {
        public virtual TB_M_Employee TB_M_Employees { get; set; }
    }
}
