using InsuranceApi.Domain.Entities;

namespace InsuranceApi.Data.Seed;

public static class AgentSeed
{
    public static readonly Agent Moein = new()
    {
        Id = UserSeed.Moein.Id,
        LicenseNumber = "f3333333333",
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
    };
}