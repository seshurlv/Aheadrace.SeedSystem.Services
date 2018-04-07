using Aheadrace.SeedSystem.DataContracts.Users;
using Aheadrace.SeedSystem.Framework.Data;
using Aheadrace.SeedSystem.Repository.Contracts;
using Aheadrace.SeedSystem.Repository.Contracts.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Aheadrace.SeedSystem.Repository.Login
{
    public class LoginRepository : DataRepository, ILoginRepository
    {
        DataRepository dbRepo;
        public LoginRepository()
        {
            dbRepo = new DataRepository();
        }        

        public bool VerifyLoginCredentials(string username, string password)
        {
            bool isValidUser = false;
            string[] tableNames = new string[1];
            Dictionary<string, object> cmdParams = new Dictionary<string, object>();
            cmdParams.Add("@UserName", username);
            cmdParams.Add("@UserPassword", password);

            DataSet ds = dbRepo.ExecuteProcedure("ValidateUser", 0, tableNames, cmdParams);
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                isValidUser = true;
            }
            return isValidUser;
        }
    }
}
