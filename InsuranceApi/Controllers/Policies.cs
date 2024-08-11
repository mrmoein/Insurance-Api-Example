namespace InsuranceApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Policies(
    ApplicationDbContext context,
    IMapper mapper
)
{
    [HttpGet]
    public async Task<ActionResult<List<PolicyDto>>> GetPolicies(
        [FromQuery] GetPoliciesQuery request,
        CancellationToken cancellationToken
    )
    {
        var policies = await context.Policies
            .WhereIf(
                request.Id != null,
                u => u.Id == request.Id
            )
            .WhereIf(
                request.CustomerId != null,
                u => u.CustomerId == request.CustomerId
            )
            .WhereIf(
                request.CoverageAmount != null,
                u => u.CoverageAmount == request.CoverageAmount
            )
            .ProjectTo<PolicyDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

        return new ActionResult<List<PolicyDto>>(policies);
    }
}