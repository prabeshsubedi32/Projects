using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Library_MVC.Models
{
    public class UserDBContext: DbContext
    {
        public DbSet<Users> users { get; set; }
    }
}