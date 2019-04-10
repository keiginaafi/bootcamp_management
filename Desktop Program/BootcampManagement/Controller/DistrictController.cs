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
    class DistrictController : SaveData, IDistrict
    {
        MyContext myContext = new MyContext();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_District> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Districts.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_M_District Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TB_M_District item)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, TB_M_District item)
        {
            throw new NotImplementedException();
        }
    }
}
