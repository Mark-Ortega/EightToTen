
using EightToTen.Services.GuessIt;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;

[ApiController]
[Route("GuessIt")]

    public class GuessItController : ControllerBase
    {
        private readonly IGuessItServices _guessItServices;

        public GuessItController(IGuessItServices guessItServices)
        {
            _guessItServices = guessItServices;
        }

        [HttpGet]
        [Route("EasyGuess/{guess}")]
        public string EasyGuess(string guess)
        {
            return _guessItServices.EasyGuess(guess);
        }

        [HttpGet]
        [Route("MediumGuess/{guess}")]
        public string MediumGuess(string guess)
        {
            return _guessItServices.MediumGuess(guess);
        }

        [HttpGet]
        [Route("HardGuess/{guess}")]

        public string HardGuess(string guess)
        {
            return _guessItServices.HardGuess(guess);
        }
    }
