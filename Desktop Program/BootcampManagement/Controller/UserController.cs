using BootcampManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampManagement.Model;
using BootcampManagement.Save;

namespace BootcampManagement.Controller
{
    class UserController : IUser
    {
        static MyContext myContext = new MyContext();
        SaveData Newi = new SaveData(myContext);

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_User> Get()
        {
            throw new NotImplementedException();
        }

        public TB_M_User Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TB_M_User item)
        {
            myContext.TB_M_Users.Add(item);
            //return valid.validation();
            throw new NotImplementedException();
        }

        public bool Update(int id, TB_M_User item)
        {
            throw new NotImplementedException();
        }
    }
}
