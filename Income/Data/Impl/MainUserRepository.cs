using System;
using Demo2.Data.Interface;
using Demo2.Models.Entity;

namespace Demo2.Data.Impl
{
    public class MainUserRepository:EFRepositoryBase<MainUser>,IMainUserRepository
    {
        public MainUserRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool SignUpMainUser(MainUser user)
        {
            try
            {
                return Add(user);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}