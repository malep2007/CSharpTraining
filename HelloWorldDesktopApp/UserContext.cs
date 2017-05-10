using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace HelloWorldDesktopApp
{
    class UserContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
    }
}
