﻿using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infraustraction.Abstracts;
using SchoolProject.Infraustraction.Repositories;
using SchoolProject.Service.Abstracts;
using SchoolProject.Service.Implementations;

namespace SchoolProject.Service
{
    public static class ModuleServiceDependancies
    {
        public static IServiceCollection AddServiceDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IDepartmentService, DepartmentService>();
            //services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            return services;
        }
    }

}
