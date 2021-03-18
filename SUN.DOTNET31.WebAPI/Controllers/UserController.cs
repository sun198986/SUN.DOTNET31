using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Model;
using System.Repasitory;
using System.Threading.Tasks;

namespace SUN.DOTNET31.WebAPI.Controllers
{
    
    /// <summary>
    /// 用户
    /// </summary>
    [ApiController]
    [Route("api/user")]
    public class UserController:ControllerBase
    {

        private IUserRepasitory _userRepasitory;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="userRepasitory"></param>
        public UserController(IUserRepasitory userRepasitory)
        {
            this._userRepasitory = userRepasitory;
        }
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetUser()
        {
            var list =await _userRepasitory.GetUser();
            return Ok(list);
        }
    }
}
