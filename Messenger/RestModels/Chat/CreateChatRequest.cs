namespace Messenger.RestModels.Chat;

public sealed record CreateChatRequest
{
    public int UserID { get; init; }
    public int SpeakerID { get; init; }
}