﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aheadrace.SeedSystem.Facade.Contracts.Login
{
    public interface ILoginFacade
    {
        string VerifyLoginCredentials(string username, string password);
    }
}
