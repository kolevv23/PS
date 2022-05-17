using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UserLogin
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String FakNum { get; set; }
        public int Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ActiveTime { get; set; }
    }
}
