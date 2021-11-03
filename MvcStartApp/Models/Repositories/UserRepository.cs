using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MvcStartAppContext _context;

        public UserRepository(MvcStartAppContext context)
        {
            _context = context;
        }

        public async Task AddUser(User newUser)
        {
            newUser.Id = Guid.NewGuid();
            newUser.JoinDate = DateTime.Now;

            var entry = _context.Entry(newUser);

            if (entry.State == EntityState.Detached)
            {
                await _context.Users.AddAsync(newUser);
            }

            await _context.SaveChangesAsync();
        }

        public async Task<User[]> GetUsers()
        {
            return await _context.Users.ToArrayAsync();
        }
    }
}
