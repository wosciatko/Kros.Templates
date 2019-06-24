using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Kros.AspNetCore.Authorization;

namespace Kros.CqrsTemplate.Application.Controllers
{
    /// <summary>
    /// SecurityTest controller.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ValidationProblemDetails))]
    [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(ProblemDetails))]
    public class SecurityTestController : ControllerBase
    {
        /// <summary>
        /// Authorized endpoint.
        /// </summary>
        [HttpGet("authorized")]
        public ActionResult<string> Authorized() => Ok(new { Email = User.GetUserEmail() });

        /// <summary>
        /// AllowAnonymous endpoint.
        /// </summary>
        [HttpGet("unauthorized")]
        [AllowAnonymous]
        public ActionResult UnauthorizedEndpoint() => Ok();
    }
}
