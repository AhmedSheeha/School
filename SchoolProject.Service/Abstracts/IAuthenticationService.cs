﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Data.Entities.Identity;

namespace SchoolProject.Service.Abstracts
{
    public interface IAuthenticationService
    {
        public Task<string> GetJWTToken(User user);
    }
}
