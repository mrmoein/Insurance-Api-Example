using InsuranceApi.Domain.Entities;
using InsuranceApi.Domain.Enum;

namespace InsuranceApi.Data.Seed;

public static class CustomerSeed
{
    public static readonly Customer Ali = new()
    {
        Id = UserSeed.Ali.Id,
        DateOfBirth = DateTime.Now.AddYears(-24),
        Gender = Gender.Male,
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now,
    };
}