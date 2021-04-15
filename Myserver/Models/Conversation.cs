using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myserver.Models
{
    public class Conversation
    {
        public int id { get; set; }
        public User f_user { get; set; }
        public User s_user { get; set; }
    }
}
