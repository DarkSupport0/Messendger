using Messenger.SQL.Data.Repositories.Factory;
using Messenger.SQL.Data.Repositories;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.SQL.Data.UnitOfWork
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly MessengerDbContext _context;
        private readonly IRepositoryFactory _repositoryFactory;
        private readonly ConcurrentDictionary<Type, object> _repositories;

        public UnitOfWork(MessengerDbContext context, IRepositoryFactory repositoryFactory)
        {
            _context = context;
            _repositoryFactory = repositoryFactory;
            _repositories = new ConcurrentDictionary<Type, object>();
        }

        public async Task Commit()
        {
            await using IDbContextTransaction transaction = await _context.Database.BeginTransactionAsync();
            try
            {
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();

                throw;
            }
        }

        public IRepository Repository<TEntity>() where TEntity : class
        {
            if (!_repositories.TryGetValue(typeof(TEntity), out object? repository))
            {
                repository = _repositoryFactory.Instantiate<TEntity>(_context);
                _repositories.TryAdd(typeof(TEntity), repository);
            }

            return (IRepository)repository;
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
