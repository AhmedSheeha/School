using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SchoolProject.Core.Features.ApplicationUser.Commands.Models;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.ApplicationUser.Commands.Validation
{
    public class AddUserValidator : AbstractValidator<AddUserCommand>
    {
        public AddUserValidator()
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
            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
            RuleFor(x => x.ConfirmPassword)
                .Equal(x => x.Password).WithMessage("Password and Confirm Password should be the same")
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
        }
        public void ApplyCustomValidationsRules()
        {

        }
    }
}
