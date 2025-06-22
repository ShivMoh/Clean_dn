using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class AlumniConfiguration : IEntityTypeConfiguration<Alumni>
{
    public void Configure(EntityTypeBuilder<Alumni> builder)
    {
        builder.HasKey(e => e.Id);

        // many to one relationships
        builder
            .HasMany(e => e.Usis)
            .WithOne(e => e.Alumni)
            .HasForeignKey(e => e.AlumniId)
            .IsRequired();

        // one to one relationships
        builder
            .HasOne(e => e.MaritalStatus)
            .WithOne(e => e.Alumni)
            .HasForeignKey<Alumni>(e => e.MaritalStatusId)
            .IsRequired();
        
        builder
            .HasOne(e => e.Address)
            .WithOne(e => e.Alumni)
            .HasForeignKey<Alumni>(e => e.AddressId)
            .IsRequired();

        builder
            .HasOne(e => e.Contact)
            .WithOne(e => e.Alumni)
            .HasForeignKey<Alumni>(e => e.ContactId)
            .IsRequired();

        
        builder
            .HasOne(e => e.Gender)
            .WithOne(e => e.Alumni)
            .HasForeignKey<Alumni>(e => e.GenderId)
            .IsRequired();
        

        builder
            .HasOne(e => e.Occupation)
            .WithOne(e => e.Alumni)
            .HasForeignKey<Alumni>(e => e.OccupationId)
            .IsRequired();


        builder
            .HasOne(e => e.BiographicalInformation)
            .WithOne(e => e.Alumni)
            .HasForeignKey<Alumni>(e => e.BiographicalInformationId)
            .IsRequired();

        
    }


}