using Messenger.SQL.Builder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Builder.Products
{
    public class ChatProduct : IProduct
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}
