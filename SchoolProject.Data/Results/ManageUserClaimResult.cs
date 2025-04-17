using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Results
{
    public class ManageUserClaimResult
    {
        public int UserId { get; set; }
        public List<Userclaim> Userclaims { get; set; }
    }
    public class Userclaim
    {
        public string Type { get; set; }
        public bool value { get; set; }
    }
}
