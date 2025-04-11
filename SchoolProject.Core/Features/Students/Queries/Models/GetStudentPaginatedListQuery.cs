using MediatR;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Core.Wrapper;
using SchoolProject.Data.Helpers;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public  class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
    {
        public int pageNamber { get; set; }
        public int pageSize { get; set; }
        public StudentOrderEnum? orderBy { get; set; }
        public string? Search {  get; set; }
    }
}
