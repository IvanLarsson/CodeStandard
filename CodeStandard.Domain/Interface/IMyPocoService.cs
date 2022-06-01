using CodeStandard.Domain.DTO;

namespace CodeStandard.Domain.Interface
{
    public interface IMyPocoService
    {
        /// <summary>
        ///     Get all MyPoco objects
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<MyPocoDTO>> GetAll();
    }
}
