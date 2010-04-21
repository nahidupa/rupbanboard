using System;
using System.Collections.Generic;
using Rupban.Core;
using Rupban.Server;


namespace Rupban.LoginModule.Services
{
    public class LoginModuleService : ILoginModuleService
    {
        public List<Project> GetCurrentProjectList()
        {
            var projectKeeper=new ProjectKeeper();
            return projectKeeper.GetCurrentProjectList();
        }

        public bool LogOn(string username)
        {
            return true;
        }
    }
}