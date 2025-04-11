using AutoMapper;
using SchoolProject.Data.Entities;
using SchoolProject.Core.Features.Students.Queries.Results;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentByIdMapping()
        {
            CreateMap<Student, GetSingleStudentResponse>()
                .ForMember(dest => dest.DepartmentName,
               opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
