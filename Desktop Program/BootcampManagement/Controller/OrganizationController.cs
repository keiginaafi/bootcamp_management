using BootcampManagement.Interface;
using BootcampManagement.Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampManagement.Model;
using System.Data.Entity;

namespace BootcampManagement.Controller
{
    class OrganizationController : SaveData, IOrganization
    {
        MyContext myContext = new MyContext();
        public bool DeleteMaster(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteTransaction(int id)
        {
            throw new NotImplementedException();
        }        

        public List<TB_M_Organization> GetMaster()
        {
            var get = myContext.TB_M_Organizations.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_M_Organization GetMaster(int id)
        {
            var get = myContext.TB_M_Organizations.SingleOrDefault(x => x.id == id);
            return get;
        }

        public List<TB_T_Organization> GetTransaction()
        {
            var get = myContext.TB_T_Organizations.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_T_Organization GetTransaction(int id)
        {
            var get = myContext.TB_T_Organizations.SingleOrDefault(x => x.id == id);
            return get;
        }

        public bool InsertMaster(TB_M_Organization TB_M_Organizations)
        {
            TB_M_Organizations.CreateDate = DateTimeOffset.Now.LocalDateTime;
            TB_M_Organizations.EditDate = null;
            TB_M_Organizations.DeleteDate = null;
            myContext.TB_M_Organizations.Add(TB_M_Organizations);
            return saveData(myContext);
        }

        public bool InsertTransaction(TB_T_Organization TB_T_Organizations)
        {
            TB_T_Organizations.CreateDate = DateTimeOffset.Now.LocalDateTime;
            TB_T_Organizations.EditDate = null;
            TB_T_Organizations.DeleteDate = null;
            myContext.TB_T_Organizations.Add(TB_T_Organizations);
            return saveData(myContext);
        }

        public bool UpdateMaster(int id, TB_M_Organization TB_M_Organizations)
        {
            var get = GetMaster(id);
            if(get != null)
            {
                get.Name = TB_M_Organizations.Name;
                get.EditDate = DateTimeOffset.Now.LocalDateTime;
                myContext.Entry(get).State = EntityState.Modified;
                return saveData(myContext);
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan");
                return false;
            }
        }

        public bool UpdateTransaction(int id, TB_T_Organization TB_T_Organizations)
        {
            var get = GetTransaction(id);
            if (get != null)
            {
                get.Name = TB_T_Organizations.Name;
                get.EditDate = DateTimeOffset.Now.LocalDateTime;
                get.TB_M_Organizations = TB_T_Organizations.TB_M_Organizations;                
                myContext.Entry(get).State = EntityState.Modified;
                return saveData(myContext);
            }
            else
            {
                Console.WriteLine("Data tidak ditemukan");
                return false;
            }
        }
    }
}
