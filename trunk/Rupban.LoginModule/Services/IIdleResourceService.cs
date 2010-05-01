using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.LoginModule.Services
{
    public interface IIdleResourceService
    {
        List<Resource> GetIdleReourses();
    }
}