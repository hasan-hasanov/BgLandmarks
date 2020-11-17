using DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BgLandmarks.Controllers
{
    [ApiController]
    [Route("landmarks")]
    public class LandmarkController : Controller
    {
        private readonly LandmarkContext _context;

        public LandmarkController(LandmarkContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLandmarks()
        {
            var landmarks = await _context.Landmarks.ToListAsync();
            return Ok(landmarks);
        }
    }
}
