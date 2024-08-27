using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project_2_Form_Material_design
{
    class ApplicationContext: DbContext
    {
        public DbSet<User> Users {  get; set; }

        public ApplicationContext(): base("DefaultConnection") { }
    }
}
