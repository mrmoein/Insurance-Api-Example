namespace InsuranceApi.Domain.Common;

public class BaseAuditableEntity
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset UpdatedAt { get; set; }
}