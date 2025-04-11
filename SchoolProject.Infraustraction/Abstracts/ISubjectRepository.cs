using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolProject.Data.Entities;
using SchoolProject.Infraustraction.InfraustractureBases;

namespace SchoolProject.Infraustraction.Abstracts
{
    public interface ISubjectRepository : IGenericRepositoryAsync<Subjects>
    {
    }
}
