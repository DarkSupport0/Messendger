namespace Messenger.RestModels.BlackList;

public sealed record AddBlasckListRequest
{
    public int UserID { get; init; }
    public int BanID { get; init; }
}