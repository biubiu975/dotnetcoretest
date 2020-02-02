using System;
using System.ComponentModel.Composition;
using System.Linq;
using Demo2.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Demo2
{
    public abstract class EFRepositoryBase<TEntity>:IRepository<TEntity>where TEntity : EntityBase
    {
        [Import("EF", typeof(DbContext))]
        private Lazy<DataContext> DataContext { get; set; }

        public readonly DataContext dataContext;

        public EFRepositoryBase(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public DbContext Context
        {
            get { return DataContext.Value; }
        }
        
        public IQueryable<TEntity> Entities {
            get { return dataContext.Set<TEntity>(); }
        }

        public bool Add(TEntity entity)
        {
            dataContext.Set<TEntity>().Add(entity);
            int result = dataContext.SaveChanges();
            return result == 1? true : false;
        }
        public bool Update(TEntity entity)
        {
            dataContext.Set<TEntity>().Update(entity);
            int result = dataContext.SaveChanges();
            return result == 1? true : false;
        }
    }
}