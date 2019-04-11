using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_Site : BaseModel
    {
        public string Company { get; set; }
        public string Division { get; set; }
        public DateTime DateOnBoardSite { get; set; }
        public DateTime LongTimeDUration { get; set; }
        public virtual TB_M_BootcampMember TB_M_BootcampMembers { get; set; }
    }
}
