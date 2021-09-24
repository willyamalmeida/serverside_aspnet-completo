using Microsoft.Extensions.Logging;

namespace serverside_aspnet.Controllers
{
    public class HomeController : ControllerBase
    {
        public HomeController(ILogger<HomeController> logger)
            : base(logger)
        {
        }
    }
}
