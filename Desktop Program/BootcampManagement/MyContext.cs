using BootcampManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampManagement
{
    class MyContext :DbContext
    {
        public MyContext() : base("MyContext")
        {

        }

        public DbSet<TB_M_District> TB_M_Districts { get; set; }
        public DbSet<TB_M_Role> TB_M_Roles { get; set; }
        public DbSet<TB_M_Province> TB_M_Provinces { get; set; }
        public DbSet<TB_M_Region> TB_M_Regions { get; set; }
        public DbSet<TB_M_Religion> TB_M_Religions { get; set; }
        public DbSet<TB_M_User> TB_M_Users { get; set; }
        public DbSet<TB_M_Village> TB_M_Villages { get; set; }
        public DbSet<TB_M_Employee> TB_M_Employees { get; set; }

    }
}
