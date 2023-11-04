namespace Messenger.SQL.Commands.User.AddFriend
{
    public sealed record AddFriendsDto
    {
        public AddFriendsDto(int firstUserId, int secondUserId)
        {
            FirstUserId = firstUserId;
            SecondUserId = secondUserId;
        }

        public int FirstUserId { get; }
        public int SecondUserId { get; }
    }
}
