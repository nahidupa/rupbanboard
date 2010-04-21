using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.LoginModule.Services
{
    public interface IProjectService
    {
        List<Project> GetCurrentProjectList();
    }
}