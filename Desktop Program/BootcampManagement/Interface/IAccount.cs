using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface IAccount
    {
        List<TB_M_Account> Get();
        TB_M_Account Get(int id);
        bool Insert(TB_M_Account account);
        bool Update(int id, TB_M_Account account);
        bool Delete(int id);
    }
}
