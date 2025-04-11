using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infraustraction.Abstracts;
using SchoolProject.Infraustraction.Data;
using SchoolProject.Infraustraction.InfraustractureBases;

namespace SchoolProject.Infraustraction.Repositories
{
    public class InstructorRepository : GenericRepositoryAsync<Instructor>, IInstructorRepository
    {
        private readonly DbSet<Instructor> instructors;
        public InstructorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            instructors = dbContext.Set<Instructor>();
        }
    }
}
