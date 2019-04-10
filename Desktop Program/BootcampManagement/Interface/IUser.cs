using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Interface
{
    interface IUser
    {
        List<TB_M_User> Get();
        TB_M_User Get(int id);
        bool Insert(TB_M_User item);
        bool Update(int id, TB_M_User item);
        bool Delete(int id);
    }
}
