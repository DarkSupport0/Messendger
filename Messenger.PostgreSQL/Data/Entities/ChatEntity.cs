using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.PostgreSQL.Data.Entities
{
    public class ChatEntity
    {
        public int ID;
        public int UserID;
        public string username;
        public int SpeakerID;
        public string Speakerusername;
        public string Speakerfirstname;
        public string Speakerlastname;
        public bool IsFriend;
        public DateTime CreateChat = DateTime.Now;

    }
}
