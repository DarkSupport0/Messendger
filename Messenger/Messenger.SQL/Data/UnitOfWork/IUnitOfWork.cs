using Messenger.SQL.Data.Repositories;

namespace Messenger.SQL.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task Commit();
        IRepository Repository<TEntity>() where TEntity : class;
    }
}
