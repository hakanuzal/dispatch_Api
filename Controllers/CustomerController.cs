using DispatchApi.Models;
using DispatchApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace DispatchApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseMongoController<Customer>
    {
        //test deneme
        public CustomerController(CustomerRepository CustomerRepository) : base(CustomerRepository)
        {
        }
    }
}