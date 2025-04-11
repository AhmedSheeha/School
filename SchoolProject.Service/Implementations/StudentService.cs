using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Data.Helpers;
using SchoolProject.Infraustraction.Abstracts;
using SchoolProject.Service.Abstracts;

namespace SchoolProject.Service.Implementations
{
    internal class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<string> AddAsync(Student student)
        {
            await _studentRepository.AddAsync(student);
            return "Success";
        }

        public async Task<string> DeleteAsync(Student student)
        {
            var trans = _studentRepository.BeginTransaction();
            try
            {
                await _studentRepository.DeleteAsync(student);
                await trans.CommitAsync();
                return "Success";
            }catch(Exception ex)
            {
                await trans.RollbackAsync();
                return "Failed";
            }
      
        }

        public async Task<string> EditAsync(Student student)
        {
            await _studentRepository.UpdateAsync(student);
            return "Success";
        }

        public IQueryable<Student> FilterStudentPaginatedQuerable(StudentOrderEnum orderEnum, string search)
        {
            var queryable = _studentRepository.GetTableNoTracking().Include(x => x.Department).AsQueryable();
            if (!string.IsNullOrWhiteSpace(search))
            {
                queryable = queryable.Where(x => x.Name.Contains(search));
            }
            switch (orderEnum)
            {
                case StudentOrderEnum.StudID:
                    queryable = queryable.OrderBy(x => x.StudID);
                    break;
                case StudentOrderEnum.Name:
                    queryable = queryable.OrderBy(x => x.Name);
                    break;
                case StudentOrderEnum.Address:
                    queryable = queryable.OrderBy(x => x.Address);
                    break;
                case StudentOrderEnum.DepartmentName:
                    queryable = queryable.OrderBy(x => x.Department.DName);
                    break;
            }
            return queryable;
        }


        public async Task<List<Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetStudentsListAsync();
        }

        public IQueryable<Student> GetAllStudentsByDepartmentIdQueryable(int DID)
        {
            return _studentRepository.GetTableNoTracking().Where(x => x.DID.Equals(DID)).AsQueryable();
        }

        public IQueryable<Student> GetAllStudentsQueryable()
        {
            return _studentRepository.GetTableNoTracking().Include(x => x.Department).AsQueryable();
        }

        public async Task<Student> GetStudentByIdAsync(int id)
        {
            // var student = await _studentRepository.GetByIdAsync(id);
            var student = _studentRepository.GetTableNoTracking()
                .Include(s => s.Department).Where(s => s.StudID.Equals(id)).FirstOrDefault();
            return student;
        }

        public async Task<bool> IsNameExist(string name)
        {
            var studentResult = _studentRepository.GetTableNoTracking().Where(x => x.Name.Equals(name)).FirstOrDefault();
            if (studentResult != null) return true;
            return false;
        }

        public async Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            var studentResult = _studentRepository.GetTableNoTracking().Where(x => x.Name.Equals(name)& !x.StudID.Equals(id)).FirstOrDefault();
            if (studentResult != null) return true;
            return false;
        }
    }
}
