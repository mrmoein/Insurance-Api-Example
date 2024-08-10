namespace InsuranceApi.Domain.Entities;

public class CustomerAgent
{
    public int CustomerId { get; set; }
    public int AgentId { get; set; }
    public DateTime AssignedDate { get; set; }

    // Navigation properties
    public Customer Customer { get; set; }
    public Agent Agent { get; set; }
}