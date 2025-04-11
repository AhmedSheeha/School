using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infraustraction.Abstracts;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Service.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<Department> GetDepartmentById(int id)
        {
            var student = await _departmentRepository.GetTableNoTracking().Where(x => x.DID.Equals(id))
                    .Include(x => x.DepartmentSubjects).ThenInclude(x => x.Subjects).
                    Include(x => x.Instructors)
                    .Include(x => x.Instructor)
                    .FirstOrDefaultAsync();
            return student;
        }

        public async Task<bool> IsDepartmentIdExist(int id)
        {
            return await _departmentRepository.GetTableNoTracking().AnyAsync(e => e.DID.Equals(id));
        }
    }
}
