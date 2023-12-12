using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace async.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : Controller
    {
        private readonly IFoodService food;
    }
}
