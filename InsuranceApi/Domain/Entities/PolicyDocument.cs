using System.ComponentModel.DataAnnotations;
using InsuranceApi.Domain.Common;

namespace InsuranceApi.Domain.Entities;

public class PolicyDocument : BaseAuditableEntity
{
    public int Id { get; set; }

    public int PolicyId { get; set; }

    [MaxLength(36)]
    public string Name { get; set; }

    [MaxLength(36)]
    public string Type { get; set; }

    [MaxLength(36)]
    public string Path { get; set; }

    // Navigation properties
    public Policy Policy { get; set; }
}