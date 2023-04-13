using DDD_Template.Application.Contracts;
using DDD_Template.Domain.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDD_Template.Infrastructure.Persistance.Repositories
{
    internal class DataRepository<TEntity> : IRepository<TEntity>
        where TEntity : class, IAggregateRoot
    {
        private readonly ApplicationDbContext db;

        public DataRepository(ApplicationDbContext db) => this.db = db;

        public IQueryable<TEntity> All() => this.db.Set<TEntity>();

        public Task<int> SaveChanges(CancellationToken cancellation = default) =>
            this.db.SaveChangesAsync(cancellation);
    }
}
