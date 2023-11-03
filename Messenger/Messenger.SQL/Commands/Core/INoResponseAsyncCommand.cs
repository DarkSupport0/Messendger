namespace Messenger.SQL.Commands.Core
{
    public interface INoResponseAsyncCommand<in TData>
    {
        Task Execute(TData data);
    }
}
