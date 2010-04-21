using System;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;

namespace Rupban.LoginModule.Controller
{
    public class ProjectsController : IProjectsController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public ProjectsController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void ViewRupbanBoard()
        {
            
        }
    }
}