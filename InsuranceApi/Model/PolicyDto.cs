namespace InsuranceApi.Model;

public class PolicyDto
{
    public int Id { get; set; }
    public string Number { get; set; }
    public int CustomerId { get; set; }
    public string Type { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal Premium { get; set; }
    public decimal CoverageAmount { get; set; }
    public string Status { get; set; }
    public CustomerDto Customer { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Policy, PolicyDto>();
        }
    }
}