using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNGPublicApi.Controllers
{
    [Route("/")]
    [ApiController]
    public class HNGController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetResult()
        {
            var result = new
            {
                email = "doghenerewego@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/UmukoroHub/HNGPublicApi/"
            };

            return Ok(result);
        }


    }
}
