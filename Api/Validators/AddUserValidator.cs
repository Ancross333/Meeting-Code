using Api.Requests;
using FluentValidation;

namespace Api.Validators
{
    public class AddUserValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserValidator() 
        {
            RuleFor(x => x.Name)
                .Must(BeNoMoreThan16Chatacters)
                .WithMessage("Username cannot be more than 16 characters");
        }

        private bool BeNoMoreThan16Chatacters(string username)
        {
            return username.Length <= 16;
        }
    }
}
