﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Presenters;
using Rupban.LoginModule.Views;
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
            LoginPresenter presenter = _container.Resolve<LoginPresenter>();

            IRegion mainRegion = _regionManager.Regions[RegionNames.MainRegion];
            mainRegion.Add(presenter.View);
        }

        private void RegisterViewsAndServices()
        {
            _container.RegisterType(typeof(ILoginController), typeof(LoginController),true);
            _container.RegisterType(typeof(ILoginView), typeof(LoginView),true);
            _container.RegisterType(typeof(ILoginPresenter), typeof(LoginPresenter), true);
            
        }
    }
}