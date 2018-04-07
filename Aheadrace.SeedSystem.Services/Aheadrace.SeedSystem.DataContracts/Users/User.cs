using Aheadrace.SeedSystem.DataContracts.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.DataContracts.Users
{
    public class User : Common.Common
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public Role Role { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public FarmDetails FarmDetails { get; set; }
    }

    public class Role : Common.Common
    {
        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class FarmDetails : Common.Common
    {
        public int Id { get; set; }
        public string FarmAddress { get; set; }
        public string FarmContact { get; set; }
    }    
}
