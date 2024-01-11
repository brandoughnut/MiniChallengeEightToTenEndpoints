using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTenEndpoints.Services.Magic8Ball;

namespace MiniChallengeEightToTenEndpoints.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class Magic8BallController : ControllerBase
    {
    private readonly IMagic8BallService _magic8BallService;

    public Magic8BallController(IMagic8BallService magic8BallService)
        {
        _magic8BallService = magic8BallService;
    }
        [HttpGet]
        [Route("Magic8Ball")]
        public string Magic8Ball()
        {
            
            return _magic8BallService.Magic8Ball(); 
            
        }
    }
