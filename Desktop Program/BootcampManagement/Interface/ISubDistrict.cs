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
<<<<<<< HEAD:Desktop Program/BootcampManagement/Interface/IRegion.cs
        List<TB_M_Region> Get();
        List<TB_M_Region> GetList(int id);
        TB_M_Region Get(int id);
        bool Insert(TB_M_Region item);
        bool Update(int id, TB_M_Region item);
=======
        List<TB_M_Sub_District> Get();
        TB_M_Sub_District Get(int id);
        bool Insert(TB_M_Sub_District item);
        bool Update(int id, TB_M_Sub_District item);
>>>>>>> remotes/origin/master:Desktop Program/BootcampManagement/Interface/ISubDistrict.cs
        bool Delete(int id);
    }
}
