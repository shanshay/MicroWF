using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp2
{
    class ProfileService
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }       

        public int? DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
