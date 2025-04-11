using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using SchoolProject.Core.Features.Students.Commands.Models;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Students.Commands.Validations
{
    public class EditSstudentValidator : AbstractValidator<EditStudentCommand>
    {
        private readonly IStudentService _studentService;
        public EditSstudentValidator(IStudentService studentService)
        {
            _studentService = studentService;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
        }
        public void ApplyValidationsRules()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("Name Must not be Empty")
                .NotNull().WithMessage("Name Must not be null")
                .MaximumLength(250);
            RuleFor(x => x.Address)
                .NotEmpty().WithMessage("Address Must not be Empty")
                .NotNull().WithMessage("Address Must not be null")
                .MaximumLength(250);
        }
        public void ApplyCustomValidationsRules()
        {
            RuleFor(x => x.Name).MustAsync(async (model, key, CancellationToken) => !await _studentService.IsNameExistExcludeSelf(key, model.Id))
                .WithMessage("Name is Exist");
        }
    }
}
