using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMVCDataAnnotations.Models
{
    public class UserContext : DbContext
    {
        public DbSet<UserDetails> Users { get; set; }
    }
}