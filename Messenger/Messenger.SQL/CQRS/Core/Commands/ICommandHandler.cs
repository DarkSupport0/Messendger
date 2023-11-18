namespace Messenger.SQL.CQRS.Core.Commands
{
    public interface ICommandHandler<in TCommand> where TCommand : ICommand
    {
        Task Handle(TCommand command);
    }
}
