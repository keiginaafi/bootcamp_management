using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_Locker : BaseModel
    {
        public string Number_locker { get; set; }
        public DateTime Date_locker { get; set; }
        public DateTime End_DateLocker { get; set; }

    }
}
