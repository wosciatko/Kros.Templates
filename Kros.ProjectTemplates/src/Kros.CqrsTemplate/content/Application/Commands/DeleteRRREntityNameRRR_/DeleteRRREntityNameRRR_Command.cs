using MediatR;

namespace Kros.CqrsTemplate.Application.Commands
{
    /// <summary>
    /// Delete RRREntityNameRRR_ command.
    /// </summary>
    public class DeleteRRREntityNameRRR_Command : IRequest<Unit>
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="id">RRREntityNameRRR_ id.</param>
        public DeleteRRREntityNameRRR_Command(int id)
        {
            Id = id;
        }

        /// <summary>
        /// Id.
        /// </summary>
        public int Id { get; }
    }
}