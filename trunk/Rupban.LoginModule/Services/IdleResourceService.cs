using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.ServiceAgent;

namespace Rupban.LoginModule.Services
{
    public class IdleResourceService : IIdleResourceService
    {
        private readonly IServiceCallerAgent _serviceCallerAgent;
        public IdleResourceService(IUnityContainer unityContainer)
        {
            _serviceCallerAgent = unityContainer.Resolve<IServiceCallerAgent>();

        }
        public List<Resource> GetIdleReourses()
        {
            return _serviceCallerAgent.GetIdleReourses();
        }
    }
}