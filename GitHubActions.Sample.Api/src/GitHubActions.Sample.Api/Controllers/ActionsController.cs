using GitHubActions.Sample.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace GitHubActions.Sample.Api.Controllers
{
    [ApiController]
    [Route("Actions")]
    public class ActionsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ActionsController> _logger;

        public ActionsController(ILogger<ActionsController> logger)
        {
            _logger = logger;
        }
        

        [HttpGet]
        public ActionResult<Action> Get()
        {
            return Ok(new Actions
            {
                Name = "GitHub Actions",
                Version = "1.0"
            });
        }
    }
}