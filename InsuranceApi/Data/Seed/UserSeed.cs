namespace InsuranceApi.Data.Seed;

public static class UserSeed
{
    public static readonly User Moein = new()
    {
        Id = 1,
        FirstName = "Moein",
        LastName = "Aghamirzaei",
        Email = "moein@gmail.com",
        PhoneNumber = "09373333333",
        Address = "Address",
        City = "Abhar",
        State = "Zanjan",
        ZipCode = "333333333",
        Country = "Iran",
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    };

    public static readonly User Ali = new()
    {
        Id = 2,
        FirstName = "Ali",
        LastName = "Ahangary",
        Email = "Ali@gmail.com",
        PhoneNumber = "0922222222",
        Address = "Address",
        City = "Qazvin",
        State = "Qazvin",
        ZipCode = "22222222",
        Country = "Iran",
        CreatedAt = DateTime.Now,
        UpdatedAt = DateTime.Now
    };
}