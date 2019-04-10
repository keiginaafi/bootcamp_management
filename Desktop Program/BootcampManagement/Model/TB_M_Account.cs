using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_Account : BaseModel
    {
        public string Username { get; set; }
        public string Password { get; set; } 
        public virtual TB_M_Role TB_M_Roles { get; set; }
    }
}
