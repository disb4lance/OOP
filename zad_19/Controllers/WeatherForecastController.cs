using Microsoft.AspNetCore.Mvc;

namespace zad_19.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get([FromQuery] string x) { 
            return Ok(x);
        }

        [HttpPost]

        public ActionResult Post([FromBody] string x) {     
            return Ok(x);
        }

        [HttpPut]
        public ActionResult Put([FromBody] string x)
        {
            return Ok(x);
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] string x)
        {
            return Ok(x);
        }
    }
}
