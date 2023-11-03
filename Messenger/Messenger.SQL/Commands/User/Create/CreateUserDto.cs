﻿namespace Messenger.SQL.Commands.User.Create
{
    public sealed record CreateUserDto
    {
        public CreateUserDto(string username, string firstname, string lastname, DateTime birthday, string email, string phone, string country)
        {
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Email = email;
            Phone = phone;
            Country = country;
        }

        public string Username { get; }
        public string Firstname { get; }
        public string Lastname { get; }
        public DateTime Birthday { get; }
        public string Email { get; }
        public string Phone { get; }
        public string Country { get; }
    }
}
