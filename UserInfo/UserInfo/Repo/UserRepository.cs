using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UserInfo.Models;

namespace UserInfo.Repo
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetUsers()
        {
            UserContext contxt = new UserContext();
           return  contxt.userData.ToList();
        }

        public User GetUsers(int Id)
        {
            UserContext contxt = new UserContext();
            return contxt.userData.ToList().Find(x=>x.Id==Id);
        }

        public void Remove(int id)
        {
            //throw new NotImplementedException();
        }

        public void Update(int id)
        {
           // throw new NotImplementedException();
        }
    }
}