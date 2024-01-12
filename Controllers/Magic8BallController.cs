
using EightToTen.Services.Magic8Ball;
using Microsoft.AspNetCore.Mvc;

namespace EightToTen.Controllers;
    public class Magic8BallController : ControllerBase
    {
        private readonly IMagic8BallServices _magic8BallServices;

        public Magic8BallController(IMagic8BallServices magic8BallServices)
        {
            _magic8BallServices = magic8BallServices;
        }

        [HttpGet]
        [Route("8ball/{question}")]

        public string M8Ball(string question)
        {
            return _magic8BallServices.M8Ball(question);
        }
    }
