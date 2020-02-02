using System.Linq;

namespace Demo2
{
    public interface IRepository<TEntity>
    {
        IQueryable<TEntity> Entities { get; }
    }
}