﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using rupban.loginmodule.Commands;
using rupban.loginmodule.Controller;
using Rupban.LoginModule.Controller;
using rupban.loginmodule.Presenters;
using Rupban.LoginModule.Presenters;
using Rupban.LoginModule.Services;
using rupban.loginmodule.Views;
using Rupban.LoginModule.Views;
using Rupban.ServiceAgent;
using Rupban.UI.Infrastructure;

namespace Rupban.LoginModule
{
    public class LoginModule:IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public LoginModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            RegisterViewsAndServices();
            
            ILoginPresenter presenter = _container.Resolve<ILoginPresenter>();

            IRegion mainRegion = _regionManager.Regions[RegionNames.MainRegion];
            mainRegion.Add(presenter.View);
        }

        private void RegisterViewsAndServices()
        {
          
            _container.RegisterType(typeof(IAdminPanelController), typeof(AdminPanelController), true);
            _container.RegisterType(typeof(IAdminPanelView), typeof(AdminPanelView), true);
            _container.RegisterType(typeof(IAdminPanelPresenter), typeof(AdminPanelPresenter), true);

            _container.RegisterType(typeof(IProjectsController), typeof(ProjectsController), true);
            _container.RegisterType(typeof(IProjectsView), typeof(ProjectsView), true);
            _container.RegisterType(typeof(IProjectsPresenter), typeof(ProjectsPresenter), true);


            _container.RegisterType(typeof(IRupbanBoardController), typeof(RupbanBoardController), true);
            _container.RegisterType(typeof(IRupbanBoardView), typeof(RupbanBoardView), true);
            _container.RegisterType(typeof(IRupbanBoardPresenter), typeof(RupbanBoardPresenter), true);

            _container.RegisterType(typeof(ILoginService), typeof(LoginService), true);
            _container.RegisterType(typeof(IProjectService), typeof(ProjectService), true);
            _container.RegisterType(typeof(IRupbanBoardService), typeof(RupbanBoardService), true);

         
            _container.RegisterType(typeof(IPanelColumnController), typeof(PanelColumnController), false);
            _container.RegisterType(typeof(IPanelColumnView), typeof(PanelColumnView), false);
            _container.RegisterType(typeof(IPanelColumnPresenter), typeof(PanelColumnPresenter), false);
            _container.RegisterType(typeof(IPanelColumnService), typeof(PanelColumnService), false);

            _container.RegisterType(typeof(IServiceCallerAgent), typeof(ServiceCallerAgent), true);
            _container.RegisterType(typeof(IServiceLisnerAgent), typeof(ServiceListenerAgent), true);
            
         

            _container.RegisterType(typeof(ILoginController), typeof(LoginController), true);
            _container.RegisterType(typeof(ILoginView), typeof(LoginView), true);
            _container.RegisterType(typeof(ILoginPresenter), typeof(LoginPresenter), true);

            _container.RegisterType(typeof(ITicketPresenter), typeof(TicketPresenter), false);
            _container.RegisterType(typeof(ITicketView), typeof(TicketView), false);
            _container.RegisterType(typeof(ITicketController), typeof(TicketController), false);
            _container.RegisterType(typeof(ITicketService), typeof(TicketService), false);

            _container.RegisterType(typeof(ILoginCommand), typeof(LoginCommand), true);
            _container.RegisterType(typeof(IMoveTicketCommand), typeof(MoveTicketCommand), false);


            _container.RegisterType(typeof(IPeerBoxPresenter), typeof(PeerBoxPresenter), false);
            _container.RegisterType(typeof(IPeerBoxView), typeof(PeerBoxView), false);
            //_container.RegisterType(typeof(IPeerBoxController), typeof(PeerBoxController), false);
            //_container.RegisterType(typeof(IPeerBoxService), typeof(PeerBoxService), false);


            _container.RegisterType(typeof(IInDevColumnController), typeof(InDevColumnController), true);
            _container.RegisterType(typeof(IInDevColumnView), typeof(InDevColumnView), false);
            _container.RegisterType(typeof(IInDevColumnPresenter), typeof(InDevColumnPresenter), false);
            _container.RegisterType(typeof(IInDevColumnService), typeof(InDevColumnService), false);


            _container.RegisterType(typeof(IIdleResourceView), typeof(IdleResourceView), false);
            _container.RegisterType(typeof(IIdleResourcePresenter), typeof(IdleResourcePresenter), false);
            _container.RegisterType(typeof(IIdleResourceService), typeof(IdleResourceService), true);
     

            

            
            

            
        }
    }
}
