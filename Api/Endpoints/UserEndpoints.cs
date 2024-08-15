using MediatR;
using Api.Endpoints.Common;
using Application.Users.Commands.CreateUser;

namespace Api.Endpoints;

public static class UserEndpoints
{
    public static RouteGroupBuilder UserGroup(this RouteGroupBuilder group)
    {
        group
            .MapPost(
                $"/{EndpointsMetadata.CreateUser}",
                async (ISender sender, CreateUserCommand command) => await sender.Send(command)
            )
            .WithName(EndpointsMetadata.CreateUser)
            .WithOpenApi(operation =>
                new(operation)
                {
                    Summary = EndpointsMetadata.CreateUserSummary,
                    Description = EndpointsMetadata.CreateUserDescription
                }
        );

        return group;
    }
}
