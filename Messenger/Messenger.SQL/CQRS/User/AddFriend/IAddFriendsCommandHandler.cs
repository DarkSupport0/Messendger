﻿using Messenger.SQL.CQRS.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.CQRS.User.AddFriend
{
    internal interface IAddFriendsCommandHandler : ICommandHandler<AddFriendsCommand>
    {
    }
}