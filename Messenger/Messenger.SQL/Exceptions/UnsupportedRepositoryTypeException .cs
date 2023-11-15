using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Exceptions
{
    public sealed class UnsupportedRepositoryTypeException : Exception
    {
        public UnsupportedRepositoryTypeException(string typeName) : base(typeName)
        {
        }
    }
}
