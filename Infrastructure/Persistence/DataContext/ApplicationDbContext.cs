using Domain.Common.Models;
using Domain.Entities;
using Infrastructure.Persistence.Interceptors;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.DataContext;

public class ApplicationDbContext : DbContext {

    private readonly PublishDomainEventInterceptor _publishDomainEventsInterceptor;
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options, 
        PublishDomainEventInterceptor publishDomainEventInterceptor) : base(options) {
            
        _publishDomainEventsInterceptor = publishDomainEventInterceptor;
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Gender> Genders { get; set; }
    public DbSet<MaritalStatus> MaritalStatuses { get; set; }
    public DbSet<BiographicalInformation> BiographicalInformation { get; set; }
    public DbSet<UserCategory> UserCategories { get; set; }
    public DbSet<Alumni> Alumnis { get; set; }
    public DbSet<Usi> Usis { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Occupation> Occupations { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Program> Programs { get; set; }
    public DbSet<ProgramCategory> ProgramCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .Ignore<List<IDomainEvent>>()
            .ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.AddInterceptors(_publishDomainEventsInterceptor);

        base.OnConfiguring(optionsBuilder);
    }
}