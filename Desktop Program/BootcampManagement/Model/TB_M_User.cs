using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Model
{
    class TB_M_User : BaseModel
    {
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public DateTimeOffset Date_of_birth { get; set; }
        public bool IsMarried { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Photo { get; set; }
        public string Street_address { get; set; }
        public virtual TB_M_Village TB_M_Villages { get; set; }
        public virtual TB_M_Religion TB_M_Religions { get; set; }
    }
}
