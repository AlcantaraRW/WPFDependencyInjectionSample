using DesktopDependencyInjectionSample.Domain.Entities;

namespace DesktopDependencyInjectionSample.Domain.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
    }
}
