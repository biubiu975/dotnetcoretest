using Demo2.Models.Entity;

namespace Demo2.Data.Interface
{
    public interface IMainUserRepository:IRepository<MainUser>
    {
        bool SignUpMainUser(MainUser user);
    }
}