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
        public DateTime birtday { get; set; }
        public string Email { get; set; }
        public string numphone { get; set; }
        public string country { get; set; }

        /*public UserEntity(string username, string firstname, string lastname, DateTime birtday, string numphone, string country)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.birtday = birtday;
            this.numphone = numphone;
            this.country = country;
        }*/

    }
}
