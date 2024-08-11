using System.ComponentModel.DataAnnotations;
using InsuranceApi.Domain.Common;
using InsuranceApi.Domain.Enum;

namespace InsuranceApi.Domain.Entities;

public class Customer : BaseAuditableEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }

    // Navigation properties
    public ICollection<Policy> Policies { get; set; }
    public ICollection<CustomerAgent> CustomerAgents { get; set; }
    public User User { get; set; }
}