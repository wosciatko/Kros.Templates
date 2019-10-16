using System;

namespace Kros.CqrsTemplate.Domain
{
    /// <summary>
    /// RRREntityNameRRR_ model.
    /// </summary>
    public class RRREntityNameRRR_
    {
        /// <summary>
        /// Id.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// DateTimeOffset of entity creation.
        /// </summary>
        public DateTimeOffset CreatedTimestamp { get; set; }

        /// <summary>
        /// DateTimeOffset of last entity update.
        /// </summary>
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
