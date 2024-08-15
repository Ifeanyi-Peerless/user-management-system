using MediatR;

namespace Application.User.Commands.CreateUser;

public record CreateUserCommand(string Firstname, string Lastname, string Email, string Password) : IRequest<CreateUserResponse>;