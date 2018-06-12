using Library_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Library_MVC.Repository
{
    public class UserRepository : IUserRepository
    {
        public List<Users> GetUsers()
        {
            UserDBContext context = new UserDBContext();
            return context.users.ToList();
        }

        public Users GetUsers(int Id)
        {
            UserDBContext contxt = new UserDBContext();
            return contxt.users.ToList().Find(x => x.Id == Id);
        }

        public void Remove(int id)
        {
            //throw new NotImplementedException();
        }

        public void Update(int id)
        {
            // throw new NotImplementedException();
        }

        Users IUserRepository.GetUsers(int Id)
        {
            throw new NotImplementedException();
        }
    }
}