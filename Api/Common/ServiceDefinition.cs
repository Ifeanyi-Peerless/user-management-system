using Api.Endpoints;
namespace Api.Endpoints.Common;

public class ServiceDefinition : IEndpointDefinition
{
    public void DefineEndPoints(WebApplication app)
    {
        app.MapGroup("/Users")
            .UserGroup()
            .RequireCors("corsapp")
            .RequireRateLimiting("LimitPolicy")
            .WithTags("Users");
    }

    public void DefineServices(IServiceCollection services) { }
}