using FluentValidation;

namespace RentACarProject.Dtos.AuthDtos
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string CheckPassword { get; set; }

    }

    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(r => r.Username).NotEmpty().WithMessage("Username is required.");
            RuleFor(r => r.Name).NotEmpty().WithMessage("Name is required.");
            RuleFor(r => r.Surname).NotEmpty().WithMessage("Surname is required.");
            RuleFor(r => r.Email).NotEmpty().WithMessage("Email address is required.");
            RuleFor(r => r.Email).EmailAddress().WithMessage("A valid email address is required.");
            RuleFor(r => r.Password).NotEmpty().MinimumLength(8).MaximumLength(20)
                .Matches(@"[A-Z]+").Matches(@"[a-z]+").Matches(@"[0-9]+").Matches(@"[\!\?\*\.]*$")
                .WithMessage("A minimum 8 characters password contains a combination of uppercase and lowercase letter and number and non alphanumeric.");
            RuleFor(r => r.CheckPassword).NotEmpty().MinimumLength(8).MaximumLength(20)
                .Matches(@"[A-Z]+").Matches(@"[a-z]+").Matches(@"[0-9]+").Matches(@"[\!\?\*\.]*$")
                .WithMessage("A minimum 8 characters password contains a combination of uppercase and lowercase letter and number and non alphanumeric.");
            RuleFor(r => r).Custom((r, context) =>
            {
                if (r.Password != r.CheckPassword)
                {
                    context.AddFailure("Password", "Passwords do not match!");
                }
            });
        }
    }
}
