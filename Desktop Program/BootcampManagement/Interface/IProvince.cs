using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface IProvince
    {
        List<TB_M_Province> Get();
        TB_M_Province Get(int id);
        bool Insert(TB_M_Province item);
        bool Update(int id, TB_M_Province item);
        bool Delete(int id);
    }
}
