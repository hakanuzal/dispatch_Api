using DispatchApi.Models;
using FluentValidation;

namespace DispatchApi.Validations
{
    public class UserValidator:AbstractValidator<Authentication>
    {
        public UserValidator()
        {
           
            RuleFor(p => p.Email).NotEmpty().WithMessage("Email Boş Geçilemez");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Password Boş Geçilemez");
            
        }
    }
}

