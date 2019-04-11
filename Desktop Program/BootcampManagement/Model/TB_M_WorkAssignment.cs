using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_WorkAssignment : BaseModel
    {
        public string Name { get; set; }
        public string Job_desk { get; set; }
        public string Project_specification { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
    }
}
