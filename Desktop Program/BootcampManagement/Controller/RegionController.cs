﻿using BootcampManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootcampManagement.Model;
using BootcampManagement.Save;

namespace BootcampManagement.Controller
{
    class RegionController : SaveData, IRegion
    {
        MyContext myContext = new MyContext();
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TB_M_Region> Get()
        {
            //throw new NotImplementedException();
            var get = myContext.TB_M_Regions.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public TB_M_Region Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(TB_M_Region item)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, TB_M_Region item)
        {
            throw new NotImplementedException();
        }
    }
}
