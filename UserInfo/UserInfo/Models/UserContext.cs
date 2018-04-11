using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace UserInfo.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> userData { get; set; }

    }
}