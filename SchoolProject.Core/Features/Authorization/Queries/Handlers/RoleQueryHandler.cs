using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Authorization.Queries.Models;
using SchoolProject.Core.Features.Authorization.Queries.Results;
using SchoolProject.Core.SharedResources;
using SchoolProject.Data.Entities.Identity;
using SchoolProject.Data.Requests;
using SchoolProject.Service.Abstracts;
using static SchoolProject.Core.Features.Authorization.Queries.Results.GetRolesListResult;

namespace SchoolProject.Core.Features.Authorization.Queries.Handlers
{
    public class RoleQueryHandler : ResponseHandler,
       IRequestHandler<GetRolesListQuery, Response<List<GetRolesListResult>>>,
       IRequestHandler<GetRoleByIdQuery, Response<GetRoleByIdResult>>,
       IRequestHandler<ManageUserRolesQuery, Response<ManageUserRolesResult>>

    {
        private readonly IAuthorizationService _authorizationService;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;

        public RoleQueryHandler(IAuthorizationService authorizationService, IMapper mapper,
            UserManager<User> userManager)
        {
            _authorizationService = authorizationService;
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<Response<List<GetRolesListResult>>> Handle(GetRolesListQuery request, CancellationToken cancellationToken)
        {
            var roles = await _authorizationService.GetRolesList();
            var result = _mapper.Map<List<GetRolesListResult>>(roles);
            return Success(result);
        }

        public async Task<Response<GetRoleByIdResult>> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            var role = await _authorizationService.GetRoleById(request.Id);
            if (role == null) return NotFound<GetRoleByIdResult>("Not Found");
            var result = _mapper.Map<GetRoleByIdResult>(role);
            return Success(result);
        }

        public async Task<Response<ManageUserRolesResult>> Handle(ManageUserRolesQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            if (user == null) return NotFound<ManageUserRolesResult>("UserNotfound");
            var result = await _authorizationService.ManageUserRolesData(user);
            return Success(result);
        }
    }

}
