using FluentValidation;

namespace Application.User.Commands.CreateUser;

public class CreateUserCommandValidator
: AbstractValidator<CreateUserCommand>
{
    public CreateUserCommandValidator()
    {
        RuleFor(t => t.Firstname).NotNull().NotEmpty().WithMessage("Firstname is required");
        RuleFor(t => t.Lastname).NotNull().NotEmpty().WithMessage("Lastname is required");
        RuleFor(t => t.Email).NotNull().NotEmpty().WithMessage("Email is required");
        RuleFor(t => t.Password).NotNull().NotEmpty().WithMessage("Password is required");
    }
}