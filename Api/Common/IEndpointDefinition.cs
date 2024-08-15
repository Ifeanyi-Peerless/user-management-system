namespace Api.Endpoints.Common;

public interface IEndpointDefinition
{
    void DefineServices(IServiceCollection services);
    void DefineEndPoints(WebApplication app);
}
