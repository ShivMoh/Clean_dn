using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class FacultyConfiguration : IEntityTypeConfiguration<Faculty>
{
    public void Configure(EntityTypeBuilder<Faculty> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.Name)
            .IsRequired();

        builder
            .Property(e => e.Campus)
            .IsRequired();


        builder
            .HasMany(e => e.Departments)
            .WithOne(e => e.Faculty)
            .HasForeignKey(e => e.FacultyId)
            .IsRequired();
        
    }


}