using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Myserver.Models;
namespace Myserver
{
    public class MessagesDBContext: DbContext
    {
        public DbSet<Message> Messages { get; set; }
        public MessagesDBContext (DbContextOptions<MessagesDBContext> options): base(options) { }

    }
}
