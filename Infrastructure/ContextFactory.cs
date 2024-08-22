using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Ardalis.GuardClauses;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=users-db;User Id=postgres;Password=postgres");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
