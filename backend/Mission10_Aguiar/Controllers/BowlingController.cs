using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_Aguiar.Models;

namespace Mission10_Aguiar.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlingRepository _bowlingRepository;
        public BowlingController(IBowlingRepository temp) 
        {
            _bowlingRepository = temp;
        }

        [HttpGet("marlins-sharks")]
        public IActionResult GetBowlersForMarlinsAndSharks()
        {
            var bowlers = _bowlingRepository.GetBowlersForMarlinsAndSharks();
            return Ok(bowlers);
        }
    }
}
