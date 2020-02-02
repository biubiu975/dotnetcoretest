using Microsoft.EntityFrameworkCore;

namespace Demo2
{
    public abstract class UnitOfWorkContextBase:IUnitOfWorkContext
    {
        protected abstract DbContext Context { get; }
    }

    public interface IUnitOfWorkContext
    {
    }
}