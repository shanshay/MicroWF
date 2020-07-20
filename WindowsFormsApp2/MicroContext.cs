using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    class MicroContext : DbContext
    {
        public MicroContext()
        : base("MicroDb")
        { }

        public DbSet<ProfileService> ProfileServices { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
