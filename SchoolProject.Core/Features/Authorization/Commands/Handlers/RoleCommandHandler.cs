using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Localization;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Authorization.Commands.Models;
using SchoolProject.Core.SharedResources;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Authorization.Commands.Handlers
{
    public class RoleCommandHandler : ResponseHandler,
       IRequestHandler<AddRoleCommand, Response<string>>,
       IRequestHandler<EditRoleCommand, Response<string>>,
       IRequestHandler<DeleteRoleCommand, Response<string>>
    {
       
        private readonly IAuthorizationService _authorizationService;

        public RoleCommandHandler(IAuthorizationService authorizationService) 
        {
            _authorizationService = authorizationService;
        }
        public async Task<Response<string>> Handle(AddRoleCommand request, CancellationToken cancellationToken)
        {
            var result = await _authorizationService.AddRoleAsync(request.RoleName);
            if (result == "Success") return Success("");
            return BadRequest<string>("Failed to Add The Role");
        }



        public async Task<Response<string>> Handle(EditRoleCommand request, CancellationToken cancellationToken)
        {
            var result = await _authorizationService.EditRoleAsync(request);
            if (result == "notFound") return NotFound<string>();
            else if (result == "Success") return Success((string)"Successfully Updated");
            else
                return BadRequest<string>(result);
        }

        public async Task<Response<string>> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var result = await _authorizationService.DeleteRoleAsync(request.Id);
            if (result == "NotFound") return NotFound<string>();
            else if (result == "Used") return BadRequest<string>("Role is Used");
            else if (result == "Success") return Success((string)"Success");
            else
                return BadRequest<string>(result);
        }
        //public async Task<Response<string>> Handle(UpdateUserRolesCommand request, CancellationToken cancellationToken)
        //{
        //    var result = await _authorizationService.UpdateUserRoles(request);
        //    switch (result)
        //    {
        //        case "UserIsNull": return NotFound<string>(_stringLocalizer[SharedResourcesKeys.UserIsNotFound]);
        //        case "FailedToRemoveOldRoles": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.FailedToRemoveOldRoles]);
        //        case "FailedToAddNewRoles": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.FailedToAddNewRoles]);
        //        case "FailedToUpdateUserRoles": return BadRequest<string>(_stringLocalizer[SharedResourcesKeys.FailedToUpdateUserRoles]);
        //    }
        //    return Success<string>(_stringLocalizer[SharedResourcesKeys.Success]);
        //}

    }
}
