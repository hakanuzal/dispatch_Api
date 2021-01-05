using DispatchApi.Models;
using DispatchApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DispatchApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TransportController : BaseMongoController<Transport>
    {
        //test deneme
        public TransportController(TransportRepository TransportRepository) : base(TransportRepository)
        {
        }
    }
}