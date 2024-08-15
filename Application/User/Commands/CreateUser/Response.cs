namespace Application.User.Commands.CreateUser;

public record CreateUserResponse(Guid UserId, string Firstname, string Lastname, string Email, string Password);