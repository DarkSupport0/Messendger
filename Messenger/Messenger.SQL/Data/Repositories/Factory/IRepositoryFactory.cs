using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.Repositories.Factory
{
    public interface IRepositoryFactory
    {
        IRepository Instantiate<TEntity>(MessengerDbContext context) where TEntity : class;
    }
}
