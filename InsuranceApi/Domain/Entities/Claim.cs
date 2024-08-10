using System.ComponentModel.DataAnnotations;
using InsuranceApi.Domain.Common;

namespace InsuranceApi.Domain.Entities;

public class Claim : BaseAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [MaxLength(36)]
    public string Number { get; set; }

    public int PolicyId { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }

    [MaxLength(36)]
    public string Description { get; set; }

    [MaxLength(36)]
    public string Status { get; set; }

    // Navigation property
    public Policy Policy { get; set; }
}