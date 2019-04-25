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
        public GetRRREntityNameRRR_Query(int id)
        {
            RRREntityNameRRR_Id = id;
        }

        /// <summary>
        /// RRREntityNameRRR_ id.
        /// </summary>
        public int RRREntityNameRRR_Id { get; set; }

        /// <summary>
        /// RRREntityNameRRR_
        /// </summary>
        [Alias("RRREntityNameRRR_Plural_")]
        public class RRREntityNameRRR_
        {
            /// <summary>
            /// RRREntityNameRRR_ Id.
            /// </summary>
            public int Id { get; set; }
        }
    }
}
