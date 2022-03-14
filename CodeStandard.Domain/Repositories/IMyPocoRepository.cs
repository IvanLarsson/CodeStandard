using CodeStandard.Domain.Entities;

namespace CodeStandard.Domain.Repositories
{
    public interface IMyPocoRepository
    {
        /// <summary>
        ///     Get all MyPoco objects from persistence
        /// </summary>
        Task<IEnumerable<MyPoco>> GetAsync(CancellationToken ct = default);
    }
}
