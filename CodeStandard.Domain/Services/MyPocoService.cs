
using CodeStandard.Domain.DTO;
using CodeStandard.Domain.Extensions;
using CodeStandard.Domain.Interface;
using CodeStandard.Domain.Repositories;

namespace CodeStandard.Domain.Services
{
    internal class MyPocoService : IMyPocoService
    {
        private readonly IMyPocoRepository repo;

        public MyPocoService(IMyPocoRepository repo)
        {
            this.repo = repo;
        }
        public async Task<IEnumerable<MyPocoDTO>> GetAll()
        {
            return (await repo.GetAsync()).ToList().ToMyPocoDTOList();
        }
    }
}
