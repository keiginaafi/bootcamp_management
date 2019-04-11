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
    class CvController : SaveData, ICv
    {
        MyContext myContext = new MyContext();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public TB_T_CV Get(int id)
        {
            //var get = myContext.TB_M_CVs;
            throw new NotImplementedException();
        }

        public bool Insert(TB_T_CV cv)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, TB_T_CV cv)
        {
            throw new NotImplementedException();
        }
    }
}
