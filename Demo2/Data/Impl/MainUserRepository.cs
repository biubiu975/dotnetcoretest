using Demo2.Data.Interface;
using Demo2.Models.Entity;

namespace Demo2.Data.Impl
{
    public class MainUserRepository:EFRepositoryBase<MainUser>,IMainUserRepository
    {
        public MainUserRepository(DataContext dataContext) : base(dataContext)
        {
        }
    }
}