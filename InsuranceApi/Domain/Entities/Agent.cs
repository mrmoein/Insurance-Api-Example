using System.ComponentModel.DataAnnotations;
using InsuranceApi.Domain.Common;

namespace InsuranceApi.Domain.Entities;

public class Agent : BaseAuditableEntity
{
    [Key]
    public int Id { get; set; }

    [MaxLength(36)]
    public string LicenseNumber { get; set; }

    // Navigation properties
    public ICollection<CustomerAgent> CustomerAgents { get; set; }
    public User User { get; set; }
}