using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.MobileNumber);

        builder
            .Property(e => e.HomeNumber);
        

        builder
            .Property(e => e.WorkNumber);

        builder
            .Property(e => e.EmailAddress);
    }


}