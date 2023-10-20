namespace Messenger.RestModels.Friends;

public sealed record AddFriendsRequest
{
    public int UserID { get; init; }
    public int FriendID { get; init; }
}