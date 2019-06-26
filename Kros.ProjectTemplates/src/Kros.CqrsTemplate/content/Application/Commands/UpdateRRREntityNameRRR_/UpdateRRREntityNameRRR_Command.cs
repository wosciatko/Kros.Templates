using MediatR;
using Newtonsoft.Json;

namespace Kros.CqrsTemplate.Application.Commands
{
    /// <summary>
    /// Update RRREntityNameRRR_ command.
    /// </summary>
    public class UpdateRRREntityNameRRR_Command : IRequest
    {
        /// <summary>
        /// Id.
        /// </summary>
        [JsonIgnore]
        public long Id { get; set; }
    }
}