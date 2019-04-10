using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface IRegion
    {
        List<TB_M_Region> Get();
        TB_M_Region Get(int id);
        bool Insert(TB_M_Region item);
        bool Update(int id, TB_M_Region item);
        bool Delete(int id);
    }
}
