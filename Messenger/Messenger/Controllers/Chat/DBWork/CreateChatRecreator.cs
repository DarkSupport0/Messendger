using Messenger.SQL.Builder.Builders.Chat.Base;
using Messenger.SQL.Builder.Directors.Chat;
using Messenger.SQL.Builder.Products;
using Messenger.SQL.CQRS.Chat.Command.Create;
using Messenger.SQL.CQRS.Chat.Create;
using Microsoft.AspNetCore.Mvc;

namespace Messenger.Controllers.Chat.DBWork
{
    public class CreateChatRecreator
    {
        private readonly ICreateChatCommandHandler _command;
        public CreateChatRecreator(ICreateChatCommandHandler command)
        {
            _command = command;
        }
        public async Task<IActionResult> Execute(CreateChatPartsCommand command, IChatBuilderByType builder)
        {
            IChatDirector director = new ChatDirector(builder);
            ChatProduct? chat = director.Make(command.Name) as ChatProduct;
            if (chat == null) { return new BadRequestResult(); }
            CreateChatCommand create = new CreateChatCommand(chat.Name, chat.Type);
            await _command.Handle(create);
            return new OkResult();
        }
    }
}
