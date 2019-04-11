using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface ICv
    {
        TB_T_CV Get(int id);
        bool Insert(TB_T_CV cv);
        bool Update(int id, TB_T_CV cv);
        bool Delete(int id);
    }
}
