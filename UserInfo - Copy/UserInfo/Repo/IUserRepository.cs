using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfo.Models;

namespace UserInfo.Repo
{
   public  interface IUserRepository
    {
        List<User> GetUsers();
        User GetUsers(int Id);
        void Remove(int id);
        void Update(int id);

    }
}
