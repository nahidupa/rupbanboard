using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.LoginModule.Services
{
    public interface ILoginService
    {
        bool LogOn(string username);
    }
}