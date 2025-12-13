using Microsoft.AspNetCore.Mvc;

namespace GAVito.AdService.Controllers
{
    [ApiController]
    [Route("AdController")]
    public class AdController : ControllerBase
    {
        public AdController()
        {
        }

        [HttpPost]
        public async Task CreateAd()
        {

        }
    }
}
