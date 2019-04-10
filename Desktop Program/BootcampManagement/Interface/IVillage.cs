using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface IVillage
    {
        List<TB_M_Village> Get();
        TB_M_Village Get(int id);
        bool Insert(TB_M_Village item);
        bool Update(int id, TB_M_Village item);
        bool Delete(int id);
    }
}
