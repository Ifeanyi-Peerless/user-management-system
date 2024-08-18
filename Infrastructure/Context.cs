using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Ardalis.GuardClauses;

public class ApplicationDbContextFactory(IConfiguration configuration) : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        Guard.Against.Null(
            connectionString,
            message: "Connection string 'DefaultConnection' not found."
        );

        optionsBuilder.UseNpgsql(connectionString);

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}
