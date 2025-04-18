﻿using AutoMapper;
using SchoolProject.Data.Entities;
using SchoolProject.Core.Features.Students.Queries.Results;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentListMapping()
        {
            CreateMap<Student, GetStudentListResponse>()
                .ForMember(dest => dest.DepartmentName,
               opt => opt.MapFrom(src => src.Department.DName));
        }
    }
}
