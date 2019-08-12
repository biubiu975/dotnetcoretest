using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Interface
{
    public interface IFileRepository:IRepository<UploadFile>
    {
        bool AddEntity(UploadFile file);
        bool EditEntity(UploadFile file);
        bool DeletedEntity(string code);
    }
}