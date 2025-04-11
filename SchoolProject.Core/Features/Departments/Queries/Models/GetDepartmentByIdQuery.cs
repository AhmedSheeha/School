using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Departments.Queries.Results;

namespace SchoolProject.Core.Features.Departments.Queries.Models
{
    public class GetDepartmentByIdQuery : IRequest<Response<GetDepartmentByIdResponse>>
    {
        public int StudentPageNumber { get; set; }
        public int StudentPageSize { get; set; }
        public int Id { get; set; }
        public GetDepartmentByIdQuery() { }
        public GetDepartmentByIdQuery(int id, int Number, int Size)
        {
            Id = id;
            StudentPageNumber = Number;
            StudentPageSize = Size;
        }
    }
}
