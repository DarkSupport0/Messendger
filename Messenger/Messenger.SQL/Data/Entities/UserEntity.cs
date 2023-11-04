namespace Messenger.SQL.Data.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Country { get; set; }

        public virtual ICollection<BlackListEntity> BlackListEntities { get; set; }
        public virtual ICollection<FriendsEntity> FriendsEntities { get; set; }
        public virtual ICollection<MessageEntity> MessageEntities { get; set; }
        public virtual ICollection<UserChatEntity> UserChatEntities { get; set; }
        public UserEntity(string username, string firstname, string lastname, DateTime birthday, string email, string phone, string country)
        {
            Username = username;
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
            Email = email;
            Phone = phone;
            Country = country;
        }
    }
}
