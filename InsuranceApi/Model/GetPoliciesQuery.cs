namespace InsuranceApi.Model;

public class GetPoliciesQuery
{
    public int? Id { get; set; }
    public int? CustomerId { get; set; }
    public decimal? CoverageAmount { get; set; }
}