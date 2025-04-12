using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SchoolProject.Core.Features.ApplicationUser.Commands.Models;

namespace SchoolProject.Core.Features.ApplicationUser.Commands.Validation
{
    public class ChangeUserPasswordValidator : AbstractValidator<ChangeUserPasswordCommand>
    {
        public ChangeUserPasswordValidator()
        {
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Id Must not be Empty")
                .NotNull().WithMessage("Id Must not be null");
            RuleFor(x => x.CurrentPassword)
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
            RuleFor(x => x.NewPassword)
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.NewPassword).WithMessage("Password MissMatch")
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
        }
        public void ApplyCustomValidationsRules()
        {

        }
    }
}
