using Application.Common.Interfaces.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.Email)
            .IsRequired();

        builder
            .Property(e => e.Password)
            .IsRequired();

        
        builder
            .HasOne(e => e.UserCategory)
            .WithOne(e => e.User)
            .HasForeignKey<User>(e => e.UserCategoryId)
            .IsRequired();   
    }


}