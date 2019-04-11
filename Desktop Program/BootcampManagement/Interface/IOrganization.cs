using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface IOrganization
    {
        List<TB_M_Organization> GetMaster();
        List<TB_T_Organization> GetTransaction();
        TB_M_Organization GetMaster(int id);
        TB_T_Organization GetTransaction(int id);
        bool InsertMaster(TB_M_Organization TB_M_Organizations);
        bool UpdateMaster(int id, TB_M_Organization TB_M_Organizations);
        bool DeleteMaster(int id);
        bool InsertTransaction(TB_T_Organization TB_T_Organizations);
        bool UpdateTransaction(int id, TB_T_Organization TB_T_Organizations);
        bool DeleteTransaction(int id);
    }
}
