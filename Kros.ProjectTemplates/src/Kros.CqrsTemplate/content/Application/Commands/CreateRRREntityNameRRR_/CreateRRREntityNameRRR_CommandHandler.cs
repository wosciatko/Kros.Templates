using Kros.CqrsTemplate.Application.Model;
using Kros.Utils;
using Mapster;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Kros.CqrsTemplate.Application.Commands
{
    /// <summary>
    /// Create RRREntityNameRRR_ Command Handler.
    /// </summary>
    public class CreateRRREntityNameRRR_CommandHandler : IRequestHandler<CreateRRREntityNameRRR_Command, int>
    {
        private readonly IRRREntityNameRRR_Repository _repository;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="repository">RRREntityNameRRR_ repository.</param>
        public CreateRRREntityNameRRR_CommandHandler (IRRREntityNameRRR_Repository repository)
        {
            _repository = Check.NotNull(repository, nameof(repository));
        }

        /// <inheritdoc />
        public async Task<int> Handle(CreateRRREntityNameRRR_Command request, CancellationToken cancellationToken)
        {
            var item = request.Adapt<RRREntityNameRRR_>();
            await _repository.CreateRRREntityNameRRR_Async(item);

            return item.Id;
        }
    }
}
