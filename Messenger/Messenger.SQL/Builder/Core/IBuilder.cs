using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Builder.Core
{
    public interface IBuilder
    {
        public void Reset();
        public IProduct GetProduct();
    }
}
