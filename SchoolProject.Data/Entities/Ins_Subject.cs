using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Entities
{
    public class Ins_Subject
    {
        [Key]
        public int Ins_Id { get; set; }
        [Key]
        public int Sub_Id { get; set; }
        [ForeignKey(nameof(Ins_Id))]
        [InverseProperty("Ins_Subjects")]
        public Instructor? instructor { get; set; }
        [ForeignKey(nameof(Sub_Id))]
        [InverseProperty("Ins_Subjects")]
        public Subjects? subject { get; set; }

    }
}
