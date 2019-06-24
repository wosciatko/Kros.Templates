using System.Threading.Tasks;

namespace Kros.CqrsTemplate.Domain
{
    /// <summary>
    /// Interface which describe repository for persistating <see cref="RRREntityNameRRR_"/>.
    /// </summary>
    public interface IRRREntityNameRRR_Repository
    {
        /// <summary>
        /// Create new item in repository.
        /// </summary>
        /// <param name="item">Creating item.</param>
        Task CreateRRREntityNameRRR_Async(RRREntityNameRRR_ item);

        /// <summary>
        /// Update item in repository.
        /// </summary>
        /// <param name="item">Updating item.</param>
        Task UpdateRRREntityNameRRR_Async(RRREntityNameRRR_ item);

        /// <summary>
        /// Delete item by <paramref name="id"/>.
        /// </summary>
        /// <param name="id">Item id.</param>
        Task DeleteRRREntityNameRRR_Async(long id);
    }
}
