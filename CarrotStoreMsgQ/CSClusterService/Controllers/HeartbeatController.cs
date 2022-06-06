using Microsoft.AspNetCore.Mvc;

namespace CSClusterService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeartbeatController : ControllerBase
    {
        private readonly ILogger<HeartbeatController> _logger;

        public HeartbeatController(ILogger<HeartbeatController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "HeartbeatPing")]
        public IActionResult HeartbeatPing()
        {
            return null;
        }
    }
}