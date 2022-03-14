using CodeStandard.Domain.Entities;
using CodeStandard.Domain.Repositories;

using Microsoft.EntityFrameworkCore;

namespace CodeStandard.Infrastructre.Persistance.Context
{
    internal class Repository : IMyPocoRepository
    {
        private readonly ICodeStandardDbContext context;

        public Repository(ICodeStandardDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<MyPoco>> GetAsync(CancellationToken ct = default)
        {
            return await context.MyPocos.ToListAsync(ct);
        }
    }
}
