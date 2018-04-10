using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vNext.MVC.Models;

namespace vNext.MVC.Repository
{
    public class UserRepository
    {
        public static List<UserInfo> GetUsers()
        {
            List<UserInfo> lstUser = new List<UserInfo>();
            lstUser.Add(new UserInfo()
            {
                Id = 1,
                UserNamed = "abc",
                Password = "123"
            });
            lstUser.Add(new UserInfo()
            {
                Id = 2,
                UserNamed = "abc1",
                Password = "123"
            });

            lstUser.Add(new UserInfo()
            {
                Id = 3,
                UserNamed = "abc2",
                Password = "123"
            });

            return lstUser;
        }
    }
}