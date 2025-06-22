using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class OccupationConfiguration : IEntityTypeConfiguration<Occupation>
{
    public void Configure(EntityTypeBuilder<Occupation> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.OccupationName)
            .IsRequired();

        builder
            .Property(e => e.Organization)
            .IsRequired();
        

        builder
            .Property(e => e.FormerPosition);

        builder
            .Property(e => e.FormerOrganization);
    }


}