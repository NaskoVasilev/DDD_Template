using DDD_Template.Domain.Common;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DDD_Template.Application.Contracts
{
    public interface IRepository<out TEntity>
        where TEntity : IAggregateRoot
    {
        IQueryable<TEntity> All();

        Task<int> SaveChanges(CancellationToken cancellation = default);
    }
}
