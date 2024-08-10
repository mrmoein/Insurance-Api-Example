using System.ComponentModel.DataAnnotations;
using InsuranceApi.Domain.Common;

namespace InsuranceApi.Domain.Entities;

public class Policy : BaseAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [MaxLength(36)]
    public string Number { get; set; }

    public int CustomerId { get; set; }

    [MaxLength(36)]
    public string Type { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Premium { get; set; }
    public decimal CoverageAmount { get; set; }

    [MaxLength(36)]
    public string Status { get; set; }

    // Navigation properties
    public Customer Customer { get; set; }
    public ICollection<Claim> Claims { get; set; }
    public ICollection<Payment> Payments { get; set; }
    public ICollection<Beneficiary> Beneficiaries { get; set; }
    public ICollection<PolicyDocument> PolicyDocuments { get; set; }
}