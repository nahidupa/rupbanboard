using System;
using System.Collections.Generic;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.LoginModule.Presenters;
using Rupban.UI.Infrastructure;

namespace Rupban.LoginModule.Controller
{
    public class RupbanBoardController : IRupbanBoardController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public RupbanBoardController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }

        public void LoadBoardColumnView(List<TemplateCollum> templateCollums)
        {
            var region = _regionManager.Regions[RegionNames.ColumnRegion];
            foreach (var templateCollum in templateCollums)
            {
                 var panelColumnPresenter = _container.Resolve<IPanelColumnPresenter>();
                 region.Add(panelColumnPresenter.View, templateCollum.Title.ToString());
            }
           
        }
    }
}