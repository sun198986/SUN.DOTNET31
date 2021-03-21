using System;
using System.Collections.Generic;
using System.EFCore;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repasitory.Pattern.Impl
{
    public class RepasitoryBase<T>:IRepasitoryBase<T> where T: class
    {
        private readonly MSDBContext _dbContext;

        public RepasitoryBase(MSDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
        }


        public async Task<bool> SaveChangeAsync()
        {
            return await _dbContext.SaveChangesAsync() >= 0;
        }
    }
}
