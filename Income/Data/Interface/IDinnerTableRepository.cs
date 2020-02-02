using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Interface
{
    public interface IDinnerTableRepository:IRepository<DinnerTable>
    {
        bool AddEntity(DinnerTableModel dinnerTableModel);
        bool EditEntity(DinnerTableModel dinnerTableModel);
        bool DeletedEntity(string code);
    }
}