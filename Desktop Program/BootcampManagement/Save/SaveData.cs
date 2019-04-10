using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement.Save
{
    class SaveData
    {
        bool status = false;
        MyContext myContext = new MyContext();

        public SaveData(MyContext _myContext)
        {
            myContext = _myContext;
        }
        public SaveData() { }

        public SaveData() { }

        //var result = Convert.ToBoolean(myContext.SaveChanges());
        public bool saveData(MyContext myContext)
        {
            var result = (myContext.SaveChanges());
            if (result > 0)
            {
                Console.WriteLine("Succses");
                status = true;
            }
            else
            {
                Console.WriteLine("NotSuccses");
            }
            return status;
        }
    }
}
