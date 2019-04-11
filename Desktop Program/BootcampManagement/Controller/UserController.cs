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
    class UserController : SaveData, IUser
    {
        MyContext myContext = new MyContext();
        //SaveData saveData = new SaveData(myContext);

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_User> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Users.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_M_User Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TB_M_User item)
        {
            myContext.TB_M_Users.Add(item);
            //return saveData(myContext);
            //throw new NotImplementedException();
            var result = (myContext.SaveChanges());
            return true;
        }

        public bool Update(int id, TB_M_User item)
        {
            throw new NotImplementedException();
        }
    }
}
