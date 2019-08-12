using System;
using System.Linq;
using Demo2.Data.Interface;
using Demo2.Models.Entity;
using Demo2.Models.Temp;

namespace Demo2.Data.Impl
{
    public class DinnerTableRepository:EFRepositoryBase<DinnerTable>,IDinnerTableRepository
    {
        public DinnerTableRepository(DataContext dataContext) : base(dataContext)
        {
        }

        public bool AddEntity(DinnerTableModel dinnerTableModel)
        {
            try
            {
                DinnerTable dinnerTable = new DinnerTable();
                dinnerTable.Code = Guid.NewGuid().ToString("D");
                dinnerTable.UniqueCode = dinnerTableModel.uniquecode;
                dinnerTable.Status = 0;
                dinnerTable.Name = dinnerTableModel.name;
                dinnerTable.Date = DateTime.Now;
                
                return Add(dinnerTable);
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool EditEntity(DinnerTableModel dinnerTableModel)
        {
            try
            {
                var dinnerTable = Entities.FirstOrDefault(dt => dt.Code == dinnerTableModel.code && dt.IsDeteled == 0);
                dinnerTable.Name = dinnerTableModel.name;
                return Update(dinnerTable);
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
                var dinnerTable = Entities.FirstOrDefault(dt => dt.Code == code && dt.IsDeteled == 0);
                dinnerTable.IsDeteled = 1;
                return Update(dinnerTable);;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}