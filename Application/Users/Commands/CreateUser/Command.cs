using MediatR;

namespace Application.Users.Commands.CreateUser;

public record CreateUserCommand(string Firstname, string Lastname, string Email, string Password) : IRequest<CreateUserResponse>;