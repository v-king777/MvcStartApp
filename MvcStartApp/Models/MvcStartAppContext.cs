using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Models
{
    public class MvcStartAppContext : DbContext
    {
        public MvcStartAppContext(DbContextOptions<MvcStartAppContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
    }
}
