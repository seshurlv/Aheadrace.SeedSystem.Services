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
        public string ImageURL { get; set; }
        public List<FarmDetails> FarmDetails { get; set; }
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
        public string FarmLattitude { get; set; }
        public string FarmLongitude { get; set; }
        public string FarmTitle { get; set; }
        public string FarmImageURL { get; set; }
        //public List<FarmDetailAttributes> FarmDetailAttributes { get; set; }
    }    

    public class FarmDetailAttributes : Common.Common
    {
        public int Id { get; set; }
        public string FarmAttributeKey { get; set; }
        public string FarmAttributeValue { get; set; }
    }
}
