using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SchoolProject.Core.Features.Authentication.Commands.Models;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Authentication.Commands.Validations
{
    public class SignInValidator : AbstractValidator<SignInCommand>
    {
        public SignInValidator()
        {
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Username Must not be Empty")
                .NotNull().WithMessage("Username Must not be null");
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Password Must not be Empty")
                .NotNull().WithMessage("Password Must not be null");
        }
        public void ApplyCustomValidationsRules()
        {
            
        }
    }
}
