using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.PostgreSQL.Data.Entities
{
    public class FriendsEntity
    {
        public int ID;
        public int UserID;
        public string username;
        public int FriendID;
        public string friendusername;
        public string friendfirstname;
        public string friendlastname;
    }
}
