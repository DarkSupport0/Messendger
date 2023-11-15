using Messenger.SQL.Data.Entities;
using Messenger.SQL.Data.Repositories.BlackList;
using Messenger.SQL.Data.Repositories.Chat;
using Messenger.SQL.Data.Repositories.Friends;
using Messenger.SQL.Data.Repositories.Message;
using Messenger.SQL.Data.Repositories.User;
using Messenger.SQL.Data.Repositories.UserChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messenger.SQL.Exceptions;

namespace Messenger.SQL.Data.Repositories.Factory
{
    public class RepositoryFactory : IRepositoryFactory
    {
        public IRepository Instantiate<TEntity>(MessengerDbContext context) where TEntity : class
        {
            return typeof(TEntity).Name switch
            {
                nameof(BlackListEntity) => new BlackListRepository(context),
                nameof(ChatEntity) => new ChatRepository(context),
                nameof(FriendsEntity) => new FriendsRepository(context),
                nameof(MessageEntity) => new MessageRepository(context),
                nameof(UserEntity) => new UserChatRepository(context),
                nameof(UserChatEntity) => new UserRepository(context),
                _ => throw new UnsupportedRepositoryTypeException(typeof(TEntity).Name)
            };
        }
    }
}
