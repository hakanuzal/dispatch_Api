using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DispatchApi.Models;
using DispatchApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DispatchApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserLoginController : Controller
    {
        private readonly UserLoginService _UserService;
        public UserLoginController(UserLoginService UserService)
        {
            _UserService = UserService;
        }

        [HttpGet("Login")]  
        
        public virtual async Task<ActionResult> Login(string _Email,string _Password)
        {
            return Ok(await this._UserService.LoginMethod(_Email,_Password));
        }
    }
}
