using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Kros.KORM;
using Kros.Utils;
using System.Linq;

namespace Kros.CqrsTemplate.Application.Queries
{
    /// <summary>
    /// Query handler for RRREntityNameRRR_ queries.
    /// </summary>
    public class GetRRREntityNameRRR_Plural_QueryHandler
        : IRequestHandler<GetAllRRREntityNameRRR_Plural_Query, IEnumerable<GetAllRRREntityNameRRR_Plural_Query.RRREntityNameRRR_>>,
        IRequestHandler<GetRRREntityNameRRR_Query, GetRRREntityNameRRR_Query.RRREntityNameRRR_>
    {
        private readonly IDatabase _database;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="database">Database.</param>
        public GetRRREntityNameRRR_Plural_QueryHandler(IDatabase database)
        {
            _database = Check.NotNull(database, nameof(database));
        }

        /// <inheritdoc />
        public Task<IEnumerable<GetAllRRREntityNameRRR_Plural_Query.RRREntityNameRRR_>> Handle(
            GetAllRRREntityNameRRR_Plural_Query request,
            CancellationToken cancellationToken)
            => Task.FromResult(_database.Query<GetAllRRREntityNameRRR_Plural_Query.RRREntityNameRRR_>().AsEnumerable());

        /// <inheritdoc />
        public Task<GetRRREntityNameRRR_Query.RRREntityNameRRR_> Handle(
            GetRRREntityNameRRR_Query request,
            CancellationToken cancellationToken)
            => Task.FromResult(_database.Query<GetRRREntityNameRRR_Query.RRREntityNameRRR_>()
                .FirstOrDefault(i => i.Id == request.RRREntityNameRRR_Id));
    }
}
