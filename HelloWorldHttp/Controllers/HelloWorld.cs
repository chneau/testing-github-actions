using Microsoft.AspNetCore.Mvc;

namespace HelloWorldHttp.Controllers
{
    public class SayHi : ControllerBase
    {
        [Route("/")]
        public IActionResult Get()
        {
            return Ok($"Hello world. v0.0.3");
        }
    }
}
