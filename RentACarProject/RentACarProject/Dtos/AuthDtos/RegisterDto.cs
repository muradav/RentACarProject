using FluentValidation;

namespace RentACarProject.Dtos.AuthDtos
{
    public class RegisterDto
    {
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string CheckPassword { get; set; }

    }

    public class RegisterDtoValidator : AbstractValidator<RegisterDto>
    {
        public RegisterDtoValidator()
        {
            RuleFor(r => r.Username).NotEmpty().WithMessage("Please fill the gap");
            RuleFor(r => r.Name).NotEmpty().WithMessage("Please fill the gap");
            RuleFor(r => r.Surname).NotEmpty().WithMessage("Please fill the gap");
            RuleFor(r => r.Password).NotEmpty().MinimumLength(8).MaximumLength(20)
                .Matches(@"[A-Z]+").Matches(@"[a-z]+").Matches(@"[0-9]+").Matches(@"[\!\?\*\.]*$")
                .WithMessage("A minimum 8 characters password contains a combination of uppercase and lowercase letter and number and non alphanumeric");
            RuleFor(r => r.CheckPassword).NotEmpty().MinimumLength(8).MaximumLength(20)
                .Matches(@"[A-Z]+").Matches(@"[a-z]+").Matches(@"[0-9]+").Matches(@"[\!\?\*\.]*$")
                .WithMessage("A minimum 8 characters password contains a combination of uppercase and lowercase letter and number and non alphanumeric");
            RuleFor(r => r).Custom((r, context) =>
            {
                if (r.Password != r.CheckPassword)
                {
                    context.AddFailure("Password", "Password doesn't match with first password");
                }
            });
        }
    }
}
