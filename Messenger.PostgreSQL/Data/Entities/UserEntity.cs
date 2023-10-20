using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.PostgreSQL.Data.Entities
{
    public class UserEntity
    {
        public int ID { get; set; }
        public string username { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public DateTime birthday { get; set; }
        public string email { get; set; }
        public string numphone { get; set; }
        public string country { get; set; }
    }
}
