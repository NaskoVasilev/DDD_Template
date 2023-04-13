using DDD_Template.Domain.Common;

namespace DDD_Template.Domain.Factories
{
    public interface IFactory<out TEntity>
        where TEntity : IAggregateRoot
    {
        TEntity Build();
    }
}
