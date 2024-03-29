using Api.Commands;
using FluentValidation;

namespace Api.Validators
{
    public class AddUserValidator : AbstractValidator<AddUserCommand>
    {
        public AddUserValidator() 
        {
            RuleFor(x => x.Username)
                .Must(BeNoMoreThan16Chatacters)
                .WithMessage("Username cannot be more than 16 characters");
        }

        private bool BeNoMoreThan16Chatacters(string username)
        {
            return username.Length <= 16;
        }
    }
}
