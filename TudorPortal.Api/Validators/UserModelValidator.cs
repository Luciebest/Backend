using FluentValidation;
using TudorPortal.Business.Models;

namespace TudorPortal.Api.Validators
{
    public class UserModelValidator : AbstractValidator<UserModel>
    {
        public UserModelValidator()
        {
            RuleFor(p => p.Email)
            .NotEmpty()
            .WithMessage("This section can't be empty");

            RuleFor(p => p.Hashedpassword)
            .NotEmpty()
            .WithMessage("Wrong password");
        }
    }
}
