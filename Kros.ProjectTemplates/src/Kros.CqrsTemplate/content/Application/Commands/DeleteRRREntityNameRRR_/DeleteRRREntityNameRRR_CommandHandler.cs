using Kros.CqrsTemplate.Domain;
using Kros.Utils;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kros.CqrsTemplate.Application.Commands
{
    /// <summary>
    /// Create RRREntityNameRRR_ Command Handler.
    /// </summary>
    public class DeleteRRREntityNameRRR_CommandHandler : IRequestHandler<DeleteRRREntityNameRRR_Command, Unit>
    {
        private readonly IRRREntityNameRRR_Repository _repository;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="repository">RRREntityNameRRR_ repository.</param>
        public DeleteRRREntityNameRRR_CommandHandler (IRRREntityNameRRR_Repository repository)
        {
            _repository = Check.NotNull(repository, nameof(repository));
        }

        /// <inheritdoc />
        public async Task<Unit> Handle(DeleteRRREntityNameRRR_Command request, CancellationToken cancellationToken)
        {
            await _repository.DeleteRRREntityNameRRR_Async(request.Id);

            return Unit.Value;
        }
    }
}
