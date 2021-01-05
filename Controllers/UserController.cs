using DispatchApi.Models;
using DispatchApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DispatchApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseMongoController<User>
    {
        //test deneme
        public UserController(UserRepository UserRepository) : base(UserRepository)
        {
        }


    }
}