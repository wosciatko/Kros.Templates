using Kros.CqrsTemplate.Domain;
using Kros.KORM;
using Kros.KORM.Converter;
using Kros.KORM.Metadata;

namespace Kros.CqrsTemplate.Infrastructure
{
    /// <summary>
    /// Configure database for KORM.
    /// </summary>
    public class DatabaseConfiguration : DatabaseConfigurationBase
    {
        /// <summary>
        /// Name of RRREntityNameRRR_Plural_ table in database.
        /// </summary>
        public const string RRREntityNameRRR_Plural_TableName = "RRREntityNameRRR_Plural_";

        /// <summary>
        /// Create database model.
        /// </summary>
        /// <param name="modelBuilder"><see cref="ModelConfigurationBuilder"/></param>
        public override void OnModelCreating(ModelConfigurationBuilder modelBuilder)
        {
            modelBuilder.Entity<RRREntityNameRRR_>()
                .HasTableName(RRREntityNameRRR_Plural_TableName)
                .HasPrimaryKey(f => f.Id).AutoIncrement()
                .UseConverterForProperties<string>(NullAndTrimStringConverter.ConvertNull);
        }
    }
}
