using Api.Contracts.Core.PlutoRover.Common;
using Api.Contracts.Core.PlutoRover.PlutoRover.v1;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace ApiPlutoRover.Controllers.PlutoRover.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlutoRoverController : Controller
    {
        private readonly IPlutoRover _plutoRover;
        private readonly ILogger<PlutoRoverController> _logger;

        public PlutoRoverController(IPlutoRover plutoRover, ILogger<PlutoRoverController> logger)
        {
            _plutoRover = plutoRover ?? throw new ArgumentNullException(nameof(plutoRover));
            _logger = logger;
        }

        [HttpGet("{roverId}")]
        public async Task<ActionResult<ItemResult<string>>> GetAsync(int roverId)
        {
            return await _plutoRover.GetAsync(roverId);
        }

        [HttpPost("{roverId}")]
        public async Task<ActionResult<ItemResult<string>>> ExecuteComandsAsync(int roverId, [FromBody]PlutoRoverRequest request)
        {
            return await _plutoRover.ExecuteComandsAsync(roverId, request);
        }
    }
}
