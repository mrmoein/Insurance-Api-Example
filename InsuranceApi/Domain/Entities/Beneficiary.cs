using System.ComponentModel.DataAnnotations;

namespace InsuranceApi.Domain.Entities;

public class Beneficiary
{
    [Key]
    public int Id { get; set; }

    public int PolicyId { get; set; }

    [MaxLength(36)]
    public string FirstName { get; set; }

    [MaxLength(36)]
    public string LastName { get; set; }

    [MaxLength(36)]
    public string Relationship { get; set; }

    public decimal Percentage { get; set; }

    // Navigation properties
    public Policy Policy { get; set; }
}