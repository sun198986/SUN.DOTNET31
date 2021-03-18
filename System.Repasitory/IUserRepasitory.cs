using System.Collections.Generic;
using System.Entity;
using System.Threading.Tasks;

namespace System.Repasitory
{

    public interface IUserRepasitory
    {
        public Task<IEnumerable<User>> GetUser();
    }
}
