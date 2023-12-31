﻿using Messenger.SQL.Data.Entities;
using Messenger.SQL.Dtos.Message;
using Messenger.SQL.Dtos.UserChat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Dtos.Chat
{
    public sealed record ChatInfoDto : IData
    {
        public string Name { get; }
        public string Type { get; }

        public List<ChatMessageDto> MessageEntities { get; }
        public List<UserChatDto> UserChatEntities { get; }

        public ChatInfoDto(string name, string type, List<ChatMessageDto> messages, List<UserChatDto> userchats)
        {
            Name = name;
            Type = type;
            MessageEntities = messages;
            UserChatEntities = userchats;
        }
    }
}
