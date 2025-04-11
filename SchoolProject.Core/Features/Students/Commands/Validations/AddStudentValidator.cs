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
    public class AddStudentValidator : AbstractValidator<AddStudentCommand>
    {
        private readonly IStudentService _studentService;
        private readonly IDepartmentService _departmentService;
        public AddStudentValidator(IStudentService studentService, IDepartmentService departmentService)
        {
            _studentService = studentService;
            ApplyValidationsRules();
            ApplyCustomValidationsRules();
            _departmentService = departmentService;
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
            RuleFor(x => x.Name).MustAsync(async (key, CancellationToken) => !await _studentService.IsNameExist(key))
                .WithMessage("Name is Exist");
            When(p => p.DepartmentId != null, () =>
            {
                RuleFor(x => x.DepartmentId).MustAsync(async (key, CancellationToken) => await _departmentService.IsDepartmentIdExist(key))
                .WithMessage("DepartmentId Does not Exist");
            });
        }
    }
}
