using InsuranceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApi.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Customer> Customers => Set<Customer>();
    public DbSet<Policy> Policies => Set<Policy>();
    public DbSet<Claim> Claims => Set<Claim>();
    public DbSet<Payment> Payments => Set<Payment>();
    public DbSet<Agent> Agents => Set<Agent>();
    public DbSet<CustomerAgent> CustomerAgents => Set<CustomerAgent>();
    public DbSet<Beneficiary> Beneficiaries => Set<Beneficiary>();
    public DbSet<PolicyDocument> PolicyDocuments => Set<PolicyDocument>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<User>()
            .HasOne(u => u.Agent)
            .WithOne(u => u.User)
            .HasForeignKey<Agent>(u => u.Id);

        builder.Entity<User>()
            .HasOne(u => u.Customer)
            .WithOne(u => u.User)
            .HasForeignKey<Customer>(u => u.Id);

        builder.Entity<Policy>()
            .HasOne(u => u.Customer)
            .WithMany(u => u.Policies);

        builder.Entity<Policy>()
            .HasMany(u => u.Claims)
            .WithOne(u => u.Policy);

        builder.Entity<Policy>()
            .HasMany(u => u.Payments)
            .WithOne(u => u.Policy);

        builder.Entity<Policy>()
            .HasMany(u => u.Beneficiaries)
            .WithOne(u => u.Policy);

        builder.Entity<Policy>()
            .HasMany(u => u.PolicyDocuments)
            .WithOne(u => u.Policy);

        builder.Entity<CustomerAgent>()
            .HasKey(
                u => new
                {
                    u.CustomerId,
                    u.AgentId
                }
            );
    }
}