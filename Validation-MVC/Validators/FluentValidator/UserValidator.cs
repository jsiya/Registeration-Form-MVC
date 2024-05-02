using FluentValidation;
using Validation_MVC.Models;

namespace Validation_MVC.Validators.FluentValidator;

public class UserValidator: AbstractValidator<User>
{
    public UserValidator()
    {
        RuleFor(u => u.Password)
            .NotEmpty()
            .MinimumLength(8);
        RuleFor(u => u.Username)
            .NotEmpty()
            .MinimumLength(4);
    }
}