using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolProject.Core.Features.Departments.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Mapping.Departments.QueriesMapping
{
    public partial class DepartmentProfile
    {
        public void GetDepartmentByIdMapping()
        {
            CreateMap<Department, GetDepartmentByIdResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DID))
                .ForMember(dest => dest.ManagerName, opt => opt.MapFrom(src => src.Instructor.Name))
                .ForMember(dest => dest.SubjectList, opt => opt.MapFrom(src => src.DepartmentSubjects))
                //.ForMember(dest => dest.StudentList, opt => opt.MapFrom(src => src.Students))
                .ForMember(dest => dest.InstructorList, opt => opt.MapFrom(src => src.Instructors))
                ;
            
            CreateMap<DepartmetSubject, SubjectResponse>()
                .ForMember(des => des.Id, opt => opt.MapFrom(src => src.SubID))
                .ForMember(des => des.Name, opt => opt.MapFrom(src => src.Subjects.SubjectName));

            CreateMap<Instructor, InstructorResponse>()
                .ForMember(des => des.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(des => des.Name, opt => opt.MapFrom(src => src.Name));


            //CreateMap<Student, StudentResponse>()
            //    .ForMember(des => des.Id, opt => opt.MapFrom(src => src.StudID))
            //    .ForMember(des => des.Name, opt => opt.MapFrom(src => src.Name));


        }
    }
}
