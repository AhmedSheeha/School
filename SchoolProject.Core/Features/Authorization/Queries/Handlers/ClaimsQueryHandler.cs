using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.Authorization.Queries.Models;
using SchoolProject.Core.SharedResources;
using SchoolProject.Data.Entities.Identity;
using SchoolProject.Data.Results;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Core.Features.Authorization.Queries.Handlers
{
    public class ClaimsQueryHandler : ResponseHandler,
            IRequestHandler<ManageUserClaimQuery, Response<ManageUserClaimResult>>
    {
        private readonly IAuthorizationService _authorizationService;
        private readonly UserManager<User> _userManager;

        public ClaimsQueryHandler(IAuthorizationService authorizationService,
            UserManager<User> userManager)
        {
            _authorizationService = authorizationService;
            _userManager = userManager;
        }

        public async Task<Response<ManageUserClaimResult>> Handle(ManageUserClaimQuery request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(request.UserId.ToString());
            if (user == null) return NotFound<ManageUserClaimResult>("NotFound");
            var result = await _authorizationService.ManageUserClaimData(user);
            return Success(result);
        }
    }
}
