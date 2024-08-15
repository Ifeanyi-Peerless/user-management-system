using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entities;
using MediatR;
namespace Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler(IApplicationDbContext context) : IRequestHandler<CreateUserCommand, CreateUserResponse>
{
    public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        try 
        {
            var userData = new User {
                Firstname = request.Firstname,
                Lastname = request.Lastname,
                Email = request.Email,
                Password = request.Password
            };

            await context.Users.AddAsync(userData);
            await context.SaveChangesAsync(cancellationToken);

            return new CreateUserResponse()
            {
                success = true,
                message = "User created successfully"
            };
        } catch(Exception exception)
        {
            return new CreateUserResponse
            {
                success = false,
                message = exception.Message
            };
        }
    }
}