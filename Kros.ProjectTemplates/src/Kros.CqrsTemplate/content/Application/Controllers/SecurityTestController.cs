using Kros.AspNetCore;
using Kros.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kros.CqrsTemplate.Application.Controllers
{
    /// <summary>
    /// SecurityTest controller.
    /// </summary>
    [Authorize(AuthenticationSchemes = JwtAuthorizationHelper.JwtSchemeName)]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    public class SecurityTestController : ApiBaseController
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
