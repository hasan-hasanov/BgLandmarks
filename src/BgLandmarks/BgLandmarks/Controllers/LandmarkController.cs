using DAL.Queries;
using Microsoft.AspNetCore.Mvc;

namespace BgLandmarks.Controllers
{
    [ApiController]
    [Route("landmarks")]
    public class LandmarkController : Controller
    {
        private readonly IGetLandmarksQuery _getLandmarksQuery;

        public LandmarkController(IGetLandmarksQuery getLandmarksQuery)
        {
            _getLandmarksQuery = getLandmarksQuery;
        }

        [HttpGet]
        public IActionResult GetAllLandmarks()
        {
            var landmarks = _getLandmarksQuery.Execute();
            return Ok(landmarks);
        }
    }
}
