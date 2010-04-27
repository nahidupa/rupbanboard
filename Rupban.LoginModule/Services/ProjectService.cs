using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.ServiceAgent;


namespace Rupban.LoginModule.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IServiceCallerAgent _serviceCallerAgent;
        public ProjectService(IUnityContainer unityContainer)
        {
            _serviceCallerAgent = unityContainer.Resolve<IServiceCallerAgent>();
            
        }
        public List<Project> GetCurrentProjectList()
        {

            return _serviceCallerAgent.GetCurrentProjectList();
        }
    }
}