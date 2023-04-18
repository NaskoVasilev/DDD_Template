using FluentValidation;
using static DDD_Template.Domain.ModelConstants.Common;

namespace DDD_Template.Application.Features.Identity.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            this.RuleFor(x => x.Email)
                .MinimumLength(MinEmailLength)
                .MaximumLength(MaxEmailength)
                .EmailAddress()
                .NotEmpty();

            this.RuleFor(x => x.Password)
                .MinimumLength(MinPasswordLength)
                .MaximumLength(MaxPasswordLength)
                .NotEmpty();
        }
    }
}
