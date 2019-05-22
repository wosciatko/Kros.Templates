using Kros.CqrsTemplate.Domain;
using Kros.Utils;
using Mapster;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kros.CqrsTemplate.Application.Commands
{
    /// <summary>
    /// Update RRREntityNameRRR_ Command Handler.
    /// </summary>
    public class UpdateRRREntityNameRRR_CommandHandler : IRequestHandler<UpdateRRREntityNameRRR_Command>
    {
        private readonly IRRREntityNameRRR_Repository _repository;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="repository">RRREntityNameRRR_ repository.</param>
        public UpdateRRREntityNameRRR_CommandHandler (IRRREntityNameRRR_Repository repository)
        {
            _repository = Check.NotNull(repository, nameof(repository));
        }

        /// <inheritdoc />
        public async Task<Unit> Handle(UpdateRRREntityNameRRR_Command request, CancellationToken cancellationToken)
        {
            var item = request.Adapt<RRREntityNameRRR_>();
            await _repository.UpdateRRREntityNameRRR_Async(item);

            return Unit.Value;
        }
    }
}
