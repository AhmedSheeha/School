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
    public class SubjectRepository : GenericRepositoryAsync<Subjects>, ISubjectRepository
    {
        private readonly DbSet<Subjects> subjects;
        public SubjectRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            subjects = dbContext.Set<Subjects>();
        }
    }
}
