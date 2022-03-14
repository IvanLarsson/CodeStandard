
using CodeStandard.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace CodeStandard.Infrastructre.Persistance.Context
{
    internal class CodeStandardDbContext : DbContext, ICodeStandardDbContext
    {
        public CodeStandardDbContext(DbContextOptions<CodeStandardDbContext> options) : base(options)
        { }

        public DbSet<MyPoco> MyPocos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
