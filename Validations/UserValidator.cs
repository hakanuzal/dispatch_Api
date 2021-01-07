using DispatchApi.Models;
using FluentValidation;

namespace DispatchApi.Validations
{
    public class UserValidator:AbstractValidator<Authentication>
    {
        public UserValidator()
        {
           
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email Boş Geçilemez").EmailAddress().WithMessage("Girinti mail değil");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Password Boş Geçilemez").MinimumLength(3).WithMessage("En az 3 haneli password giriniz.");
            
        }
    }
}

