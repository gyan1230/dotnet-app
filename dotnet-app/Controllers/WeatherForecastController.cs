using Microsoft.AspNetCore.Mvc;

namespace DotnetApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            throw new Exception("Simulated failure for rollback demo");
        }
    }
}
