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
            var get = myContext.TB_T_CVs.SingleOrDefault(x => x.id == id);
            return get;
            //throw new NotImplementedException();
        }

        public bool Insert(TB_T_CV cv)
        {
            cv.CreateDate = DateTimeOffset.Now.LocalDateTime;
            cv.EditDate = null;
            cv.DeleteDate = null;
            myContext.TB_T_CVs.Add(cv);
            return saveData(myContext);                        
        }

        public bool Update(int id, TB_T_CV cv)
        {
            //var get = Get(id);
            //if(get != null)
            //{
                
            //}
            //else
            //{

            //}
            throw new NotImplementedException();
        }
    }
}
