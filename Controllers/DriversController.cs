using DispatchApi.Models;
using DispatchApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DispatchApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DriversController : BaseMongoController<Drivers>
    {
        //test deneme
        public DriversController(DriversRepository DriversRepository) : base(DriversRepository)
        {
        }
    }
}