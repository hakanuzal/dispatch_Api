using DispatchApi.Models;
using DispatchApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DispatchApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : BaseMongoController<Role>
    {
        //test deneme
        public RoleController(RoleRepository RoleRepository) : base(RoleRepository)
        {
        }
    }
}