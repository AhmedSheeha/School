﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Requests
{
    public class ManageUserRolesResult
    {
        public int UserId { get; set; }
        public List<UserRoles> userRoles { get; set; }
    }
    public class UserRoles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasRole { get; set; }
    }
}
