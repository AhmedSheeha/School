using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SchoolProject.Core.Features.ApplicationUser.Commands.Models;

namespace SchoolProject.Core.Features.ApplicationUser.Commands.Validation
{
    public class EditUserValidator : AbstractValidator<EditUserCommand>
    {
        public EditUserValidator()
        {
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.FullName)
                .NotEmpty().WithMessage("Name Must not be Empty")
                .NotNull().WithMessage("Name Must not be null")
                .MaximumLength(250);
            RuleFor(x => x.UserName)
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
            RuleFor(x => x.Email)
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
            
        }
        public void ApplyCustomValidationsRules()
        {

        }
    }
}
