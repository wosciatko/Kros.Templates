using Kros.CqrsTemplate.Infrastructure;
using Kros.KORM.Metadata.Attribute;
using MediatR;

namespace Kros.CqrsTemplate.Application.Queries
{
    /// <summary>
    /// Get RRREntityNameRRR_ by Id.
    /// </summary>
    public class GetRRREntityNameRRR_Query : IRequest<GetRRREntityNameRRR_Query.RRREntityNameRRR_>
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="id">RRREntityNameRRR_ id.</param>
        public GetRRREntityNameRRR_Query(long id)
        {
            RRREntityNameRRR_Id = id;
        }

        /// <summary>
        /// RRREntityNameRRR_ id.
        /// </summary>
        public long RRREntityNameRRR_Id { get; set; }

        /// <summary>
        /// RRREntityNameRRR_
        /// </summary>
        [Alias(DatabaseConfiguration.RRREntityNameRRR_Plural_TableName)]
        public class RRREntityNameRRR_
        {
            /// <summary>
            /// RRREntityNameRRR_ Id.
            /// </summary>
            public long Id { get; set; }
        }
    }
}
