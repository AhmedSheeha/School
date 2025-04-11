﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public partial class Department
    {
        public Department()
        {
            Students = new HashSet<Student>();
            DepartmentSubjects = new HashSet<DepartmetSubject>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DID { get; set; }
        [StringLength(500)]
        public string? DName { get; set; }
        public int? InsManager { get; set; }
        [InverseProperty(nameof(Student.Department))]
        public virtual ICollection<Student> Students { get; set; }
        [InverseProperty("Department")]
        public virtual ICollection<DepartmetSubject> DepartmentSubjects { get; set; }
        [InverseProperty("Department")]    
        public virtual ICollection<Instructor> Instructors { get; set; }
        [ForeignKey(nameof(InsManager))]
        [InverseProperty("DepartmentManager")]
        public virtual Instructor? Instructor { get; set; }
    }

}
