using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolProject.Data.Entities;

namespace SchoolProject.Infraustraction.Configurations
{
    internal class StudentSubjectConfigurations : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> builder)
        {
                builder.HasOne(sc => sc.Student).WithMany(s => s.StudentSubjects)
                .HasForeignKey(sc => sc.StudID).OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(sc => sc.Subject).WithMany(s => s.StudentsSubjects)
                .HasForeignKey(sc => sc.SubID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
