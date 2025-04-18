﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.AppMetaData
{
    public static class Router
    {
        public const string SingleRoute = "{id}";
        public const string root = "Api";
        public const string version = "V1";
        public const string Rule = root + "/" + version + "/";
        public static class StudentRouting
        {
            public const string Prefix = Rule + "Student";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + SingleRoute;
            public const string Create = Prefix + "/Create";
            public const string Edit = Prefix + "/Edit";
            public const string Delete = Prefix + "/{id}";
            public const string Paginated = Prefix + "/Paginated";

        }
        public static class DepartmentRouting
        {
            public const string Prefix = Rule + "Department";
            public const string List = Prefix + "/List";
            public const string GetById = Prefix + "/id";

        }
        public static class ApplicationRouting
        {
            public const string Prefix = Rule + "User";
            public const string Create = Prefix + "/Create";
            public const string Paginated = Prefix + "/Paginated";
            public const string GetById = Prefix + SingleRoute;
            public const string Edit = Prefix + "/Edit";
            public const string ChangePassword = Prefix + "/ChangePassword";
        }
        public static class AuthorizationRouting
        {
            public const string Prefix = Rule + "Authorization";
            public const string Create = Prefix + "/Create";
            public const string Claims = Prefix + "/Claims";
            public const string Delete = Prefix + "/Delete";
            public const string Paginated = Prefix + "/Paginated";
            public const string GetById = Prefix + SingleRoute;
            public const string Edit = Prefix + "/Edit";
            public const string RoleList = Prefix + "/Role-List";
            public const string ChangePassword = Prefix + "/ChangePassword";
            public const string ManageUserRole = Prefix + "/ManageUserRoles/{id}";
            public const string UpdateUserRole = Prefix + "/Update-User-Roles";
            public const string ManageUserClaims = Claims + "/Manage-User-Claims/{userId}";
            public const string UpdateUserClaims = Claims + "/Update-User-Claims/{userId}";
        }
        public static class Authentication
        {
            public const string Prefix = Rule + "Authentication";
            public const string SignIn = Prefix + "/SignIn";
        }
    }
}
