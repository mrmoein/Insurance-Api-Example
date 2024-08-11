using InsuranceApi.Data.Seed;

namespace InsuranceApi.Data;

public class ApplicationDbContextInitialiser(
    ApplicationDbContext context
)
{
    public async Task InitialiseAsync()
    {
        try
        {
            await context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while initialising the database {ex}");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while seeding the database {ex}");
            throw;
        }
    }

    private async Task TrySeedAsync()
    {
        await AddUsers();
        await AddAgent(AgentSeed.Moein);
        await AddCustomer(CustomerSeed.Ali);
        await AddPolicies();

        await context.SaveChangesAsync();
    }

    private async Task AddUser(User user)
    {
        var isExist = await context.Users.AnyAsync(u => u.Id == user.Id);

        if (!isExist) context.Users.Add(user);
    }

    private async Task AddUsers()
    {
        await AddUser(UserSeed.Moein);
        await AddUser(UserSeed.Ali);
    }

    private async Task AddAgent(Agent agent)
    {
        var isExist = await context.Agents.AnyAsync(u => u.Id == agent.Id);

        if (!isExist) context.Agents.Add(agent);
    }

    private async Task AddCustomer(Customer customer)
    {
        var isExist = await context.Customers.AnyAsync(u => u.Id == customer.Id);

        if (!isExist) context.Customers.Add(customer);
    }

    private async Task AddPolicies()
    {
        await AddPolicy(PolicySeed.Policy01);
        await AddPolicy(PolicySeed.Policy02);
        await AddPolicy(PolicySeed.Policy03);
    }

    private async Task AddPolicy(Policy policy)
    {
        var isExist = await context.Policies.AnyAsync(u => u.Id == policy.Id);

        if (!isExist) context.Policies.Add(policy);
    }
}