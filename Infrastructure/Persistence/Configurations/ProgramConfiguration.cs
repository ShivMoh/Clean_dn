using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ProgramConfiguration : IEntityTypeConfiguration<Program>
{
    public void Configure(EntityTypeBuilder<Program> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .HasOne(e => e.ProgramCategory)
            .WithOne(e => e.Program)
            .HasForeignKey<Program>(e => e.ProgramCategoryId)
            .IsRequired();

        builder
            .HasOne(e => e.Usi)
            .WithOne(e => e.Program)
            .HasForeignKey<Program>(e => e.UsiId)
            .IsRequired();        
    }


}