using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infraustraction.Abstracts;
using SchoolProject.Infraustraction.InfraustractureBases;
using SchoolProject.Infraustraction.Repositories;

namespace SchoolProject.Infraustraction
{
    public static class ModuleInfraustractureDependancies
    {
        public static IServiceCollection AddInfraustractureDependancies(this IServiceCollection services)
        {
            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient<IDepartmentRepository, DepartmentRepository>();
            services.AddTransient<IInstructorRepository, InstructorRepository>();
            services.AddTransient<ISubjectRepository, SubjectRepository>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}
