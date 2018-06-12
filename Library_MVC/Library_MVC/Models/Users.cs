using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_MVC.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string passWord { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}