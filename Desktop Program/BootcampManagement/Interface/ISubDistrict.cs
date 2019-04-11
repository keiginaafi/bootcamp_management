using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface ISubDistrict
    {
        List<TB_M_Sub_District> Get();
        TB_M_Sub_District Get(int id);
        bool Insert(TB_M_Sub_District item);
        bool Update(int id, TB_M_Sub_District item);
        bool Delete(int id);
    }
}
