using Kros.CqrsTemplate.Domain;
using Kros.KORM;
using Kros.Utils;
using System.Threading.Tasks;

namespace Kros.CqrsTemplate.Infrastructure
{
    /// <summary>
    /// Repository for persistating <see cref="RRREntityNameRRR_"/>.
    /// </summary>
    public class RRREntityNameRRR_Repository: IRRREntityNameRRR_Repository
    {
        private IDatabase _database;

        /// <summary>
        /// Ctor.
        /// </summary>
        /// <param name="database">Database</param>
        public RRREntityNameRRR_Repository(IDatabase database)
        {
            _database = Check.NotNull(database, nameof(database));
        }

        /// <inheritdoc />
        public async Task CreateRRREntityNameRRR_Async(RRREntityNameRRR_ item)
        {
            var dbSet = _database.Query<RRREntityNameRRR_>().AsDbSet();

            dbSet.Add(item);

            await dbSet.CommitChangesAsync();
        }

        /// <inheritdoc />
        public async Task UpdateRRREntityNameRRR_Async(RRREntityNameRRR_ item)
        {
            var dbSet = _database
                .Query<RRREntityNameRRR_>()
                .AsDbSet();

            dbSet.Edit(item);

            await dbSet.CommitChangesAsync();
        }

        /// <inheritdoc />
        public async Task DeleteRRREntityNameRRR_Async(int id)
        {
            var dbSet = _database.Query<RRREntityNameRRR_>().AsDbSet();
            dbSet.Delete(new RRREntityNameRRR_() { Id = id});

            await dbSet.CommitChangesAsync();
        }
    }
}
