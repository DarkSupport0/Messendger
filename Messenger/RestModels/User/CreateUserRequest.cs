namespace Messenger.RestModels.User;

public sealed record CreateUserRequest
{
    public string username { get; init; }
    public string firstname { get; init; }
    public string Llstname { get; init; }
    public DateTime birthday { get; init; }
    public string email { get; init; }
    public string numphone { get; init; }
    public string country { get; init; }
}