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
    public class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
                builder.HasKey(x => x.DID);
                builder.Property(x => x.DName).HasMaxLength(250);

                builder.HasMany(x => x.Students).WithOne(x => x.Department)
                .HasForeignKey(x => x.DID).OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(x => x.Instructor)
                .WithOne(x => x.DepartmentManager)
                .HasForeignKey<Department>(x => x.InsManager).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
