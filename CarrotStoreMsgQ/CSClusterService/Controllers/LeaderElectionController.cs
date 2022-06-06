using Microsoft.AspNetCore.Mvc;

namespace CSClusterService.Controllers
{
    public class LeaderElectionController : Controller
    {
        public IActionResult AckLeaderElection()
        {
            return View();
        }

        public IActionResult Voting()
        {
            return View();
        }
    }
}
