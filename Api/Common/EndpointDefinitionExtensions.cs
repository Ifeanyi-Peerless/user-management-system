using System.Reflection;

namespace Api.Endpoints.Common;
public static class EndpointDefinitionExtensions
{
    public static void AddEndpointDefinitions(
       this IServiceCollection services)
    {
        var endpointDefinitions = Assembly.GetExecutingAssembly().GetTypes()
            .Where(x => typeof(IEndpointDefinition).IsAssignableFrom(x) && !x.IsInterface)
            .Select(Activator.CreateInstance).Cast<IEndpointDefinition>()
            .ToList();

        foreach (var endpointDefinition in endpointDefinitions)
        {
            endpointDefinition.DefineServices(services);
        }

        services.AddSingleton(endpointDefinitions as IReadOnlyCollection<IEndpointDefinition>);
    }

    public static void UseEndpointDefinitions(this WebApplication app)
    {
        var definitions = app.Services.GetRequiredService<IReadOnlyCollection<IEndpointDefinition>>();
        foreach (var endpointDefinition in definitions)
        {
            endpointDefinition.DefineEndPoints(app);
        }
    }
}
