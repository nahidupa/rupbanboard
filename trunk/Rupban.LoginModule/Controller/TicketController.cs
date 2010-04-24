using System;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.LoginModule.Controller;

namespace rupban.loginmodule.Controller
{
    public class TicketController : ITicketController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        public TicketController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void MoveTicket()
        {
            throw new NotImplementedException();
        }
    }
}