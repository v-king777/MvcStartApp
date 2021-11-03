using MvcStartApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repositories
{
    public interface IUserRepository
    {
        Task AddUser(User newUser);

        Task<User[]> GetUsers();
    }
}
