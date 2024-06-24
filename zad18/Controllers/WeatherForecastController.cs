using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace zad18.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly  IUserManager userManager;

        private static List<WeatherForecast> _users = new List<WeatherForecast>
    {
        new WeatherForecast{id = 1, name = "John Doe"}, new WeatherForecast{id = 2, name = "Nikita"}
    };
        public WeatherForecastController(IUserManager x) {
            userManager = x;
        }

        [HttpPost(Name = "Add")]
        public ActionResult Add([FromBody] WeatherForecast x)
        {
            var a = userManager.add(x);
            _users.Add(a);
            return Ok();
        }
    }
}
