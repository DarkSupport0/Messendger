using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Dtos.User
{
    public record UserMediatorDto
    {
        public UserMediatorDto(int id, string username, string firstname, string lastname, DateTime birthday, string email, string phone, string country)
        {
            Id = id;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Email = email;
            Phone = phone;
            Country = country;
        }
        public int Id { get; }
        public string Username { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public DateTime Birthday { get; }
        public string Email { get; }
        public string Phone { get; }
        public string Country { get; }
    }
}
