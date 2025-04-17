﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolProject.Core.Bases;
using SchoolProject.Data.Requests;

namespace SchoolProject.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
    {

    }
}
