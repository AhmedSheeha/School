using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Identity;
using SchoolProject.Core.Bases;
using SchoolProject.Core.Features.ApplicationUser.Commands.Models;
using SchoolProject.Data.Entities.Identity;

namespace SchoolProject.Core.Features.ApplicationUser.Commands.Handlers
{
    public class UserCommandHandler : ResponseHandler,
        IRequestHandler<AddUserCommand, Response<string>>
    {
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        public UserCommandHandler(IMapper mapper, UserManager<User> userManager)
        {
            _mapper = mapper;
            _userManager = userManager;
        }
        public async Task<Response<string>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user != null) return BadRequest<string>("Email Is Already Exist");
            var userByName = await _userManager.FindByNameAsync(request.UserName);
            if (userByName != null) return BadRequest<string>("Username Is Already Exist");
            var identityUser = _mapper.Map<User>(request);
            var createResult = await _userManager.CreateAsync(identityUser, request.Password);
            if (!createResult.Succeeded) 
            {
                return BadRequest<string>("Failed To Add User");
            }
            return Created("");
            
        }
    }
}
