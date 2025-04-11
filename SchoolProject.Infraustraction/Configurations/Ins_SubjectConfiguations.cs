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
    public class Ins_SubjectConfiguations : IEntityTypeConfiguration<Ins_Subject>
    {
        public void Configure(EntityTypeBuilder<Ins_Subject> builder)
        {
                builder.HasOne(sc => sc.instructor).WithMany(s => s.Ins_Subjects)
                .HasForeignKey(sc => sc.Ins_Id).OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(sc => sc.subject).WithMany(s => s.Ins_Subjects)
                .HasForeignKey(sc => sc.Sub_Id).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
