using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Myserver.Models;
namespace Myserver
{

    public class ChatDBContext: DbContext
    {
        private readonly IConfiguration _configuration;
        public ChatDBContext(IConfiguration _configuration)
        {
            this._configuration = _configuration;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Conversation> Conversations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
         => options.UseSqlServer(_configuration.GetConnectionString("SqlConnectionString"));

        public DbSet<Myserver.Models.User> User { get; set; }

    }
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }

    }
    public class Message
    {
        
     
        public int id { get; set; }
        public int msg_status { get; set; }
        public Conversation conversation { get; set; }
        public User sender { get; set; }
        public User receiver { get; set; }
        public string msg_content { get; set; }
        public DateTime msg_date { get; set; }
        public DateTime msg_time { get; set; }

    }
    public class Conversation
    {
       public int id { get; set; }
        public User f_user { get; set; }
        public User s_user { get; set; }
        public List <Message> messages { get; set; }

    }

}
