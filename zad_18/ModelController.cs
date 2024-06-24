using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class SampleController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> Get([FromBody] string param)
    {
        return $"GET запрос с параметром: {param}";
    }

    [HttpPost]
    public ActionResult<string> Post([FromQuery] string data)
    {
        return $"POST запрос с данными: {data}";
    }

    [HttpPut]
    public ActionResult<string> Put([FromQuery] string param, [FromBody] string data)
    {
        return $"PUT запрос с параметром {param} и данными: {data}";
    }

    [HttpDelete]
    public ActionResult<string> Delete([FromQuery] string param)
    {
        return $"DELETE запрос с параметром: {param}";
    }
}
