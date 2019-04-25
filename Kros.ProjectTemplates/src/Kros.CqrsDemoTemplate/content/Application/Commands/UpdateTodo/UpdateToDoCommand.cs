using Kros.CqrsDemoTemplate.Application.Commands.PipeLines;
using MediatR;
using Newtonsoft.Json;

namespace Kros.CqrsDemoTemplate.Application.Commands
{
    /// <summary>
    /// Update ToDo command.
    /// </summary>
    public class UpdateToDoCommand : IRequest, IUserResourceCommand
    {
        /// <summary>
        /// Id.
        /// </summary>
        [JsonIgnore]
        public int Id { get; set; }

        /// <summary>
        /// ToDo Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// User Id.
        /// </summary>
        [JsonIgnore]
        public int UserId { get; set; }
    }
}