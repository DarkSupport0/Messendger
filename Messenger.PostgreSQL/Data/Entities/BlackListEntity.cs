using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.PostgreSQL.Data.Entities
{
    public class BlackListEntity
    {
        public int ID;
        public int UserID;
        public string username;
        public int BanID;
        public string banusername;
        public string banfirstname;
        public string banlastname;
    }
}
