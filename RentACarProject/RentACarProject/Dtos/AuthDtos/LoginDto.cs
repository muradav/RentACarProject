using FluentValidation;

namespace RentACarProject.Dtos.AuthDtos
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class LoginDtoValidator : AbstractValidator<LoginDto>
    {
        public LoginDtoValidator()
        {
            RuleFor(r => r.Username).NotEmpty().WithMessage("Please fill the gap");
            RuleFor(r => r.Password).NotEmpty().MinimumLength(8).MaximumLength(20)
                .Matches(@"[A-Z]+").Matches(@"[a-z]+").Matches(@"[0-9]+").Matches(@"[\!\?\*\.]*$")
                .WithMessage("Please check the password"); ;
        }
    }
}
