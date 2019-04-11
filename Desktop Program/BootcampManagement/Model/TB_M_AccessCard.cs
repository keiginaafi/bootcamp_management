using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_AccessCard : BaseModel
    {
        public string Number_access { get; set; }
        public DateTime Date_accesscard { get; set; }
        public DateTime End_Dateaccesscard { get; set; }
    }
}
