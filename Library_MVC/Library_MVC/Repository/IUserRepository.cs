using Library_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_MVC.Repository
{
    public interface IUserRepository
    {
        List<Users> GetUsers();
        Users GetUsers(int Id);
        void Remove(int id);
        void Update(int id);
    }
}
