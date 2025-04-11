
using SchoolProject.Data.Entities;
using SchoolProject.Infraustraction.Abstracts;
using SchoolProject.Infraustraction.Data;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Infraustraction.InfraustractureBases;

namespace SchoolProject.Infraustraction.Repositories
{
    internal class StudentRepository : GenericRepositoryAsync<Student>, IStudentRepository
    {
        private readonly DbSet<Student> _students;
        public StudentRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _students = dbContext.Set<Student>();
        }
        public async Task<List<Student>> GetStudentsListAsync()
        {
            return await _students.Include(x => x.Department).ToListAsync();
        }
    }
}
