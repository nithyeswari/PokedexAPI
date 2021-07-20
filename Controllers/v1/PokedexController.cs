using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Pokedex.Controllers.v1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PokedexController : ControllerBase
    {
        private readonly ILogger<PokedexController> logger;

        public PokedexController(ILogger<PokedexController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            logger.LogInformation("Information World");
            logger.LogWarning("Warning World");
            logger.LogCritical("Critical World");
            logger.LogError("Error World");
            return "Hello, World!";
        }
    }
}