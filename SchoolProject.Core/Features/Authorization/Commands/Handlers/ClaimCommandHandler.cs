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
    public class ClaimsCommandHandler : ResponseHandler,
        IRequestHandler<UpdateUserClaimsCommand, Response<string>>
    {
        private readonly IAuthorizationService _authorizationService;
        public ClaimsCommandHandler(
                                    IAuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
        }
        public async Task<Response<string>> Handle(UpdateUserClaimsCommand request, CancellationToken cancellationToken)
        {
            var result = await _authorizationService.UpdateUserClaims(request);
            switch (result)
            {
                case "UserIsNull": return NotFound<string>("UserIsNull");
                case "FailedToRemoveOldClaims": return BadRequest<string>("FailedToRemoveOldClaims");
                case "FailedToAddNewClaims": return BadRequest<string>("FailedToAddNewClaims");
                case "FailedToUpdateClaims": return BadRequest<string>("FailedToUpdateClaims");
            }
            return Success<string>("Success");
        }
    }
}
