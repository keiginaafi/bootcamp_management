﻿using BootcampManagement.Interface;
using BootcampManagement.Save;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampManagement.Model;

namespace BootcampManagement.Controller
{
    class ReligionController : SaveData, IReligion
    {
        MyContext myContext = new MyContext();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_Religion> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Religions.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_M_Religion Get(int id)
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Religions.Find(id);
            return get;
        }

        public bool Insert(TB_M_Religion religion)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, TB_M_Province religion)
        {
            throw new NotImplementedException();
        }
    }
}
