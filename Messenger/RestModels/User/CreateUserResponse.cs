namespace Messenger.RestModels.User;

public sealed record CreateUserResponse
{
    public int ID { get; }
    public string username { get; }
    public string firstname { get; }
    public string lastname { get; }
    public DateTime birthday { get; }
    public string email { get; }
    public string numphone { get; }
    public string country { get; }

    public CreateUserResponse(int ID, string username, string firstname, string lastname, DateTime birthday, string email
    ,string numphone, string country)
    {
        this.ID = ID;
        this.username = username;
        this.firstname = firstname;
        this.lastname = lastname;
        this.birthday = birthday;
        this.email = email;
        this.numphone = numphone;
        this.country = country;
    }
}