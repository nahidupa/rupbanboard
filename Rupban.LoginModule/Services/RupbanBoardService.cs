using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.ServiceAgent;


namespace Rupban.LoginModule.Services
{
    public class RupbanBoardService : IRupbanBoardService
    {
        private readonly IServiceCallerAgent _serviceCallerAgent;
        public RupbanBoardService(IUnityContainer unityContainer)
        {
            _serviceCallerAgent = unityContainer.Resolve<IServiceCallerAgent>();

        }
        public List<TemplateColumn> GetTemplateCollumList(){
           
            return _serviceCallerAgent.GetTemplateCollumList();
        }
    }
}