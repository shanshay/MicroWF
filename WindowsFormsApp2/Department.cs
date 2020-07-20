using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    class Department
    {
        public int Id { get; set; }
        public string Title { get; set; } // название команды        

        public virtual ICollection<ProfileService> ProfileServices { get; set; }

        public Department()
        {
            ProfileServices = new List<ProfileService>();
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
