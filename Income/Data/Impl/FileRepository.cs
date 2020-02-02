using System;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Impl
{
    
    
    public class FileRepository:EFRepositoryBase<UploadFile>,IFileRepository
    {
        public FileRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool AddEntity(UploadFile file)
        {
            try
            {
                return Add(file);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditEntity(UploadFile file)
        {
            try
            {
                var file_ = Entities.FirstOrDefault(dt => dt.Code == file.Code && dt.IsDeteled == 0);
                file_.Name = file.Name;
                return Update(file_);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletedEntity(string code)
        {
            try
            {
                var recipeType = Entities.FirstOrDefault(dt => dt.Code == code && dt.IsDeteled == 0);
                recipeType.IsDeteled = 1;
                return Update(recipeType);
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}