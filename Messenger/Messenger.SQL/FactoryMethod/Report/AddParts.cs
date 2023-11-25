using Messenger.SQL.Dtos;
using Messenger.SQL.FactoryMethod.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.FactoryMethod.Report
{
    public sealed class AddParts : AddFormat
    {
        public override void RenderFile(IData entity)
        {
            ChatInfoDto chat = entity as ChatInfoDto;
            if (chat == null ) return;
            Parts.Add(new InfoChat(chat));
            Parts.Add(new UsersChat(chat));
            Parts.Add(new MessageChat(chat));
        }
    }
}
