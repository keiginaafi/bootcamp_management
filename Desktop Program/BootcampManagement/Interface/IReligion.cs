using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface IReligion
    {
        List<TB_M_Religion> Get();
        TB_M_Religion Get(int id);
        bool Insert(TB_M_Religion religion);
        bool Update(int id, TB_M_Province religion);
        bool Delete(int id);
    }
}
