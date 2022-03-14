using CodeStandard.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CodeStandard.Infrastructre.Persistance.EntityTypeConfiguration
{
    internal class MyPocoEntityTypeConfiguration : IEntityTypeConfiguration<MyPoco>
    {
        public void Configure(EntityTypeBuilder<MyPoco> builder)
        {
            builder.HasKey(prop => prop.ID);
            builder.Property(prop => prop.Name).HasMaxLength(200).IsRequired();
        }
    }
}
