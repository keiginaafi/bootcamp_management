using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_Lesson : BaseModel
    {
        public string Tittle { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
