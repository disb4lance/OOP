// Controllers/FetchController.cs
using Consumer;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FetchController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public FetchController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<ActionResult<List<Item>>> FetchItems()
        {
            var response = await _httpClient.GetAsync("http://localhost:5234/api/Items");
            if (response.IsSuccessStatusCode)
            {
                var items = await response.Content.ReadFromJsonAsync<List<Item>>();
                return Ok(items);
            }
            return StatusCode((int) response.StatusCode, "Error fetching data from ProviderApp");
    }
    }
}
