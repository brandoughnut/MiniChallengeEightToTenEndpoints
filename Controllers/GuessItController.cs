using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTenEndpoints.Services.GuessIt;

namespace MiniChallengeEightToTenEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly IGuessItService _guessItService;

        public GuessItController(IGuessItService guessItService)
        {
            _guessItService = guessItService;
        }
        [HttpGet]
        [Route("Guess a number from 1-10/{userInput}")]
        public string GuessItEasy(string userInput)
        {
            return _guessItService.GuessItEasy(userInput);
        }

        [HttpGet]
        [Route("Guess a number from 1-50/{userInput}")]
        public string GuessItMedium(string userInput)
        {
            return _guessItService.GuessItMedium(userInput);
        }

        [HttpGet]
        [Route("Guess a number from 1-100/{userInput}")]
        public string GuessItHard(string userInput)
        {
            return _guessItService.GuessItHard(userInput);
        }
    }
}