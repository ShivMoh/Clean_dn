using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class UsiConfiguration : IEntityTypeConfiguration<Usi>
{
    public void Configure(EntityTypeBuilder<Usi> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.UsiNumber)
            .IsRequired();

     
    }


}