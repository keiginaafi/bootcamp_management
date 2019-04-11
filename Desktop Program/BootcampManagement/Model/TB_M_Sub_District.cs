using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_Sub_District : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_M_District TB_M_Districts { get; set; }
    }
}
