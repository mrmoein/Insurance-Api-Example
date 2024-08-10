using System.ComponentModel.DataAnnotations;
using InsuranceApi.Domain.Common;

namespace InsuranceApi.Domain.Entities;

public class User : BaseAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [MaxLength(36)]
    public string FirstName { get; set; }

    [MaxLength(36)]
    public string LastName { get; set; }

    [MaxLength(255)]
    public string Email { get; set; }

    [MaxLength(36)]
    public string PhoneNumber { get; set; }
    
    [MaxLength(100)]
    public string Address { get; set; }

    [MaxLength(36)]
    public string City { get; set; }

    [MaxLength(36)]
    public string State { get; set; }

    [MaxLength(36)]
    public string ZipCode { get; set; }

    [MaxLength(36)]
    public string Country { get; set; }

    public int? AgentId { get; set; }
    public int? CustomerId { get; set; }

    // Navigation property
    public Agent? Agent { get; set; }
    public Customer? Customer { get; set; }
}