namespace Messenger.SQL.CQRS.Core
{
    public interface INoResponseAsyncCommand<in TData>
    {
        Task Execute(TData data);
    }
}
