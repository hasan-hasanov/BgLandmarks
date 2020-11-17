using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BgLandmarks.Controllers
{
    [ApiController]
    [Route("landmarks")]
    public class LandmarkController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetAllLandmarks()
        {
            await Task.Delay(1);
            return Ok();
        }
    }
}
