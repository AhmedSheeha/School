using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SchoolProject.Core.Features.Authorization.Commands.Models;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Authorization.Commands.Validators
{
    public class EditRoleValidator : AbstractValidator<EditRoleCommand>
    {
        public EditRoleValidator()
        {
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }


        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Id)
                 .NotEmpty().WithMessage("Id Name is Required")
                 .NotNull().WithMessage("Id Name Can not Be Null");
            RuleFor(x => x.Name)
                 .NotEmpty().WithMessage("Role Name is Required")
                 .NotNull().WithMessage("Role Name Can not Be Null");
        }

        public void ApplyCustomValidationsRules()
        {
           
        }

    }
}
