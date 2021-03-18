using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Scrutor;
using System.Collections.Generic;
using System.EFCore;
using System.Entity;
using System.Threading.Tasks;

namespace System.Repasitory.Impl
{
    public class UserRepasitory : IUserRepasitory
    {
        private MSDBContext _dbContext;
        public UserRepasitory(MSDBContext mSDBContext)
        {
            this._dbContext = mSDBContext;
        }

        public async Task<IEnumerable<User>> GetUser()
        {
            return await _dbContext.User.ToListAsync();
        }
    }
}
