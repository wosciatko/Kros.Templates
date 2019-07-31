using Kros.CqrsTemplate.Infrastructure;
using Kros.KORM.Metadata.Attribute;
using MediatR;
using System.Collections.Generic;

namespace Kros.CqrsTemplate.Application.Queries
{
    /// <summary>
    /// Get all RRREntityNameRRR_Plural_.
    /// </summary>
    public class GetAllRRREntityNameRRR_Plural_Query : IRequest<IEnumerable<GetAllRRREntityNameRRR_Plural_Query.RRREntityNameRRR_>>
    {
        /// <summary>
        /// Ctor.
        /// </summary>
        public GetAllRRREntityNameRRR_Plural_Query()
        {
        }

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
