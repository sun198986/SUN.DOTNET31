using System;
using System.Collections.Generic;
using System.Entity;
using System.Text;
using System.Threading.Tasks;

namespace System.Repasitory
{

    public interface ICompanyRepository
    {
        public Task<IEnumerable<CompanyExtend>> GetCompany();
    }
}
