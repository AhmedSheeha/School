using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Instructor
    {
        public Instructor()
        {
            Instructors = new HashSet<Instructor>();
            Ins_Subjects = new HashSet<Ins_Subject>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Position { get; set; }
        public int? SuperVisorId { get; set; }
        public decimal? Salary { get; set; }
        public int DID { get; set; }
        [ForeignKey(nameof(DID))]
        [InverseProperty("Instructors")]
        public Department? Department { get; set; }
        [InverseProperty("Instructor")]
        public Department? DepartmentManager { get; set; }
        [ForeignKey(nameof(SuperVisorId))]
        [InverseProperty("Instructors")]
        public Instructor? Supervisor { get; set; }
        [InverseProperty("Supervisor")]
        public virtual ICollection<Instructor> Instructors { get; set; }
        [InverseProperty("instructor")]
        public virtual ICollection<Ins_Subject> Ins_Subjects { get; set; }

    }
}
