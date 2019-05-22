using Kros.KORM.Metadata;
using Kros.KORM.Metadata.Attribute;

namespace Kros.CqrsTemplate.Domain
{
    /// <summary>
    /// RRREntityNameRRR_ model.
    /// </summary>
    [Alias("RRREntityNameRRR_Plural_")]
    public class RRREntityNameRRR_
    {
        /// <summary>
        /// Id.
        /// </summary>
        [Key(autoIncrementMethodType: AutoIncrementMethodType.Identity)]
        public int Id { get; set; }
    }
}
