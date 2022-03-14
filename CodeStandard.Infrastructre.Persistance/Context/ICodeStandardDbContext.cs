using CodeStandard.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace CodeStandard.Infrastructre.Persistance.Context
{
    internal interface ICodeStandardDbContext
    {
        DbSet<MyPoco> MyPocos { get; }
    }
}
