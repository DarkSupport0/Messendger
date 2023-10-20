namespace Messenger.RestModels.User;

public sealed record CreateUserRequest
{
    public string Username { get; init; }
    public string Firstname { get; init; }
    public string Lastname { get; init; }
    public DateTime Birthday { get; init; }
    public string Email { get; init; }
    public string Numphone { get; init; }
    public string Country { get; init; }
    
}