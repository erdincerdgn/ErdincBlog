using ErdincBlog.Data.Context;
using ErdincBlog.Data.Repositories.Abstractions;
using ErdincBlog.Data.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErdincBlog.Data.UnitofWorks
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext dbContext;

        public UnitofWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitofWork.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
