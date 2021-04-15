using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myserver.Models
{
    public class Message
    {
        public int id { get; set; }
        public int msg_status { get; set; } //1 means seen and 0 means sent but not seen
        public int senderID { get; set; }
        public int receiverID { get; set; }
        public String msg_content { get; set; }
        public DateTime time { get; set; }
        public DateTime date { get; set; }
        public Conversation conv { get; set; }

    }
}
