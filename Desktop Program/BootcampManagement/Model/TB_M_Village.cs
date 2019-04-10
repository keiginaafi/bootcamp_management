using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_Village : BaseModel
    {
        public string Name { get; set; }
        public virtual TB_M_District TB_M_Districts { get; set; }
    }
}
