using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Dtos
{
    public sealed record UserDto
    {
        public int Id { get; }
        public string Username { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public UserDto(int id, string username, string firstname, string lastname)
        {
            Id = id;
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
