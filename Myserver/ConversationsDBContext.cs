using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Myserver.Models;

namespace Myserver
{
    public class ConversationsDBContext: DbContext
    {
        public DbSet<Conversation> Conversations { get; set; }
        public ConversationsDBContext (DbContextOptions<ConversationsDBContext> options): base(options) { }
    }
}
