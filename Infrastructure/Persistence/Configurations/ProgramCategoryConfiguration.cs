using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ProgramCategoryConfiguration : IEntityTypeConfiguration<ProgramCategory>
{
    public void Configure(EntityTypeBuilder<ProgramCategory> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.Type)
            .IsRequired();
        
    }


}