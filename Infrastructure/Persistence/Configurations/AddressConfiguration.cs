using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.Line1)
            .IsRequired();

        builder.Property(e => e.Line2);
        
        builder
            .Property(e => e.City)
            .IsRequired();

        builder
            .Property(e => e.State)
            .IsRequired();

        builder
            .Property(e => e.Country)
            .IsRequired();

        builder.Property(e => e.Zip);

    }


}