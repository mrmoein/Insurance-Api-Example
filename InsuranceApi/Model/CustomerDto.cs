using InsuranceApi.Domain.Enum;

namespace InsuranceApi.Model;

public class CustomerDto
{
    public int Id { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender Gender { get; set; }
    public UserDto User { get; set; }

    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Customer, CustomerDto>();
        }
    }
}