using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace openapi_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost, EndpointSummary("test dataform")]
        public ActionResult<string> DataForm([FromForm, Description("name of person")] string name, [FromForm, Description("age of person")] int age)
        {
            return Content(name);
        }

        [HttpGet, EndpointSummary("test get cookie")]
        public ActionResult<string> GetCookie([FromCookie("test"), Description("cookie name")] string test)
        {
            return Content(test);
        }
    }
}
