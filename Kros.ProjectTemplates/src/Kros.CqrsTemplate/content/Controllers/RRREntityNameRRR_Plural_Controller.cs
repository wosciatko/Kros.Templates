using Kros.CqrsTemplate.Application.Commands;
using Kros.CqrsTemplate.Application.Queries;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Kros.CqrsTemplate.Controllers
{
    /// <summary>
    /// RRREntityNameRRR_Plural_ controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RRREntityNameRRR_Plural_Controller : ControllerBase
    {
        /// <summary>
        /// Get RRREntityNameRRR_Plural_.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<GetAllRRREntityNameRRR_Plural_Query.RRREntityNameRRR_>))]
        public async Task<IEnumerable<GetAllRRREntityNameRRR_Plural_Query.RRREntityNameRRR_>> Get()
            => await this.SendRequest(new GetAllRRREntityNameRRR_Plural_Query());

        /// <summary>
        /// Get RRREntityNameRRR_ by id.
        /// </summary>
        /// <response code="200">Ok.</response>
        /// <response code="403">
        /// Forbidden when user don't have permission for RRREntityNameRRR_ with <paramref name="id"/>.
        /// </response>
        /// <response code="404">If ToDo with id <paramref name="id"/> doesn't exist.</response>
        [HttpGet("{id}", Name = nameof(GetRRREntityNameRRR_))]
        [ProducesResponseType(200, Type = typeof(GetRRREntityNameRRR_Query.RRREntityNameRRR_))]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        public async Task<GetRRREntityNameRRR_Query.RRREntityNameRRR_> GetRRREntityNameRRR_(int id)
            => await this.SendRequest(new GetRRREntityNameRRR_Query(id));

        /// <summary>
        /// Create new RRREntityNameRRR_.
        /// </summary>
        /// <param name="command">Data for creating RRREntityNameRRR_.</param>
        /// <response code="201">Created. RRREntityNameRRR_ id in body.</response>
        /// <returns>
        /// RRREntityNameRRR_ id.
        /// </returns>
        [HttpPost]
        [ProducesResponseType(201)]
        public async Task<ActionResult> CreateToDo(CreateRRREntityNameRRR_Command command)
            => await this.SendCreateCommand(command, nameof(GetRRREntityNameRRR_));

        /// <summary>
        /// Update RRREntityNameRRR_.
        /// </summary>
        /// <param name="command">Data for creating RRREntityNameRRR_.</param>
        /// <param name="id">RRREntityNameRRR_ id.</param>
        /// <response code="403">Forbidden when user don't have permission for RRREntityNameRRR_ with <paramref name="id"/>.</response>
        /// <response code="404">If RRREntityNameRRR_ with id <paramref name="id"/> doesn't exist.</response>
        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> UpdateRRREntityNameRRR_(int id, UpdateRRREntityNameRRR_Command command)
        {
            command.Id = id;

            await this.SendRequest(command);

            return Ok();
        }

        /// <summary>
        /// Delete RRREntityNameRRR_.
        /// </summary>
        /// <param name="id">RRREntityNameRRR_ id.</param>
        /// <response code="403">Forbidden when user don't have permission for RRREntityNameRRR_ with <paramref name="id"/>.</response>
        /// <response code="404">If RRREntityNameRRR_ with id <paramref name="id"/> doesn't exist.</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(403)]
        [ProducesResponseType(404)]
        public async Task<ActionResult> DeleteRRREntityNameRRR_(int id)
        {
            await this.SendRequest(new DeleteRRREntityNameRRR_Command(id));

            return Ok();
        }
    }
}
