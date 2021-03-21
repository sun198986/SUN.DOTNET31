using Common.Repasitory.Pattern;
using System.Collections.Generic;
using System.Entity;
using System.Threading.Tasks;

namespace System.Repasitory
{

    public interface IUserRepasitory:IRepasitoryBase<User>
    {
        public Task<IEnumerable<User>> GetUser();
    }
}
