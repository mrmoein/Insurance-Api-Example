using InsuranceApi.Domain.Entities;

namespace InsuranceApi.Data.Seed;

public static class PolicySeed
{
    public static readonly Policy Policy01 = new()
    {
        Id = 1,
        Number = "f1",
        CustomerId = CustomerSeed.Ali.Id,
        Type = "One",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(10),
        Premium = 0.2m,
        CoverageAmount = 0.4m,
        Status = "Status",
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
    };
    
    public static readonly Policy Policy02 = new()
    {
        Id = 2,
        Number = "f2",
        CustomerId = CustomerSeed.Ali.Id,
        Type = "One",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(10),
        Premium = 0.3m,
        CoverageAmount = 0.5m,
        Status = "Status",
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
    };
    
    public static readonly Policy Policy03 = new()
    {
        Id = 3,
        Number = "f3",
        CustomerId = CustomerSeed.Ali.Id,
        Type = "Two",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(10),
        Premium = 0.5m,
        CoverageAmount = 0.6m,
        Status = "Status",
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
    };
}