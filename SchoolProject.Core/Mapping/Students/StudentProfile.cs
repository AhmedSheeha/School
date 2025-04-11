
using AutoMapper;
using SchoolProject.Data.Entities;
using SchoolProject.Core.Features.Students.Queries.Results;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentListMapping();
            GetStudentByIdMapping();
            AddStudentCommandMapping();
            EditStudentcommandMapping();
        }
    }
}
