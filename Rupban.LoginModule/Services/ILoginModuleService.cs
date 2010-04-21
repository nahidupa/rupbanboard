using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.LoginModule.Services
{
    public interface ILoginModuleService
    {
        List<Project> GetCurrentProjectList();
        bool LogOn(string username);
    }
}