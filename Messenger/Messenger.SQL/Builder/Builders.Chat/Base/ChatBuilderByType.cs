using Messenger.SQL.Builder.Core;
using Messenger.SQL.Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Builder.Builders.Chat.Base
{
    public abstract class ChatBuilderByType : IChatBuilderByType
    {
        protected ChatProduct ChatProduct { get; set; } = new ChatProduct();

        public IProduct GetProduct()
        {
            return ChatProduct;
        }

        public void Reset()
        {
            ChatProduct = new ChatProduct();
        }

        public abstract void SetName(string chatName);
        public abstract void SetType();
    }
}
