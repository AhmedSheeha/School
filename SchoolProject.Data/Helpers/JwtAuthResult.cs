using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Data.Helpers
{
    public class JwtAuthResult
    {
        public string AccessToken { get; set; }
        public string UserName { get; set; }
        public RefreshToken RefreshToken { get; set; }
    }
    public class RefreshToken
    {
        public string TokenString { get; set; }
        public string UserName { get; set; }
        public DateTime ExpiresAt { get; set; }
    }
}
