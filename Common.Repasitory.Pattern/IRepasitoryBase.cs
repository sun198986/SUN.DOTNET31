using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repasitory.Pattern
{
    public interface IRepasitoryBase<T>
    {
        public void Add(T entity);

        public Task<bool> SaveChangeAsync();
    }
}
