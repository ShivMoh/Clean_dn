using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class BiographicalInformationConfiguration : IEntityTypeConfiguration<BiographicalInformation>
{
    public void Configure(EntityTypeBuilder<BiographicalInformation> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.FirstName)
            .IsRequired();

        builder
            .Property(e => e.LastName)
            .IsRequired();
        

        builder
            .Property(e => e.DateOfBirth)
            .IsRequired();


        builder
            .HasOne(e => e.User)
            .WithOne(e => e.BiographicalInformation)
            .HasForeignKey<BiographicalInformation>(e => e.UserId)
            .IsRequired();
        
    }


}