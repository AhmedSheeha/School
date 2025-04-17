using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Data.Results;

namespace SchoolProject.Core.Features.Authorization.Queries.Models
{
    public class ManageUserClaimQuery : IRequest<Response<ManageUserClaimResult>>
    {
        public int UserId { get; set; }
    }
}
