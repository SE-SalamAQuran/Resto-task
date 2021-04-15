using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Myserver.Models;

namespace Myserver
{
    public class UsersDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public UsersDBContext (DbContextOptions<UsersDBContext> options): base(options) { }
    }
}
