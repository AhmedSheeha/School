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
    public class DepartmentSubjectConfigurations : IEntityTypeConfiguration<DepartmetSubject>
    {
        public void Configure(EntityTypeBuilder<DepartmetSubject> builder)
        { 
                builder.HasOne(sc => sc.Department).WithMany(s => s.DepartmentSubjects)
                .HasForeignKey(sc => sc.DID).OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(sc => sc.Subjects).WithMany(s => s.DepartmetsSubjects)
                .HasForeignKey(sc => sc.SubID).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
