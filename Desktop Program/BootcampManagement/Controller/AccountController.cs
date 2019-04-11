using BootcampManagement.Interface;
using BootcampManagement.Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampManagement.Model;

namespace BootcampManagement.Controller
{
    class AccountController : SaveData, IAccount
    {
        MyContext myContext = new MyContext();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_Account> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Accounts.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_M_Account Get(int id)
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Accounts.Find(id);
            return get;
        }

        public bool Insert(TB_M_Account account)
        {
            //throw new NotImplementedException();
            myContext.TB_M_Accounts.Add(account);
            return saveData(myContext);
        }

        public bool Update(int id, TB_M_Account account)
        {
            throw new NotImplementedException();
        }
    }
}
