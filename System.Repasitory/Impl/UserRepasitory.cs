using Common.Repasitory.Pattern.Impl;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Collections.Generic;
using System.EFCore;
using System.Entity;
using System.Threading.Tasks;

namespace System.Repasitory.Impl
{
    public class UserRepasitory : RepasitoryBase<User>, IUserRepasitory
    {
        private readonly MSDBContext _dbContext;
        public UserRepasitory(MSDBContext mSDBContext):base(mSDBContext)
        {
            this._dbContext = mSDBContext;
        }

        public async Task<IEnumerable<User>> GetUser()
        {
            return await _dbContext.User.ToListAsync();
        }
    }
}
