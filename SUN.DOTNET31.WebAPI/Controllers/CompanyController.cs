using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Repasitory;
using System.Threading.Tasks;

namespace SUN.DOTNET31.WebAPI.Controllers
{
    /// <summary>
    /// 公司
    /// </summary>
    [ApiController]
    [Route("api/company")]
    public class CompanyController:ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="companyRepository"></param>
        public CompanyController(ICompanyRepository companyRepository)
        {
            this._companyRepository = companyRepository;
        }

        /// <summary>
        /// get方法
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> Index() {
            var list  = await _companyRepository.GetCompany();
            return Ok(list);
        }
    }
}
