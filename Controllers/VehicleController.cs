using DispatchApi.Models;
using DispatchApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DispatchApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : BaseMongoController<Vehicle>
    {
        //test deneme
        public VehicleController(VehicleRepository VehicleRepository) : base(VehicleRepository)
        {
        }
    }
}