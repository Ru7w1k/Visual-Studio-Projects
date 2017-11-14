using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserStatus.Model;

namespace UserStatus.Data
{
    public class UserContext : DbContext
    {
        DbSet<User> Users { get; set; }
    }
}
