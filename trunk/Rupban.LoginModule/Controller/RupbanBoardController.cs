using System;
using System.Collections.Generic;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.LoginModule.Presenters;
using Rupban.LoginModule.Views;
using Rupban.ServiceAgent;
using Rupban.UI.Infrastructure;
using System.Windows;

namespace Rupban.LoginModule.Controller
{
    public class RupbanBoardController : IRupbanBoardController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private readonly IServiceAgent _serviceAgent;
        private Dictionary<string,IRegionManager> _regionManagers;
        private Dictionary<string, IPanelColumnPresenter> _panelColumnPresenters;
        public RupbanBoardController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            try
            {
                _serviceAgent = new ServiceAgent.ServiceAgent();
            }catch
            {
            }
        
            _regionManagers=new  Dictionary<string, IRegionManager>();
            _panelColumnPresenters=new Dictionary<string, IPanelColumnPresenter>();
            _serviceAgent.GetCallbackHandler().TicketMovedCalBack += new CallbackHandler.CallbackTicketMoved(RupbanBoardController_TicketMovedCalBack);
        }

        void RupbanBoardController_TicketMovedCalBack()
        {
            MessageBox.Show("callback");
        }

        public void LoadBoardColumnView(List<TemplateColumn> templateCollums)
        {
            var region = _regionManager.Regions[RegionNames.ColumnRegion];
            foreach (var templateCollum in templateCollums)
            {
                var panelColumnPresenter = _container.Resolve<IPanelColumnPresenter>();
                panelColumnPresenter.TemplateColumn = templateCollum;
                var regionManager = region.Add(panelColumnPresenter.View, templateCollum.Title.ToString(),true);
                _regionManagers.Add(templateCollum.Title, regionManager);
                _panelColumnPresenters.Add(templateCollum.Title, panelColumnPresenter);
                
            }
        }

       

        public void LoadRowView(TemplateColumn templateColumn)
        {
            _panelColumnPresenters[templateColumn.Title].LoadTicketView(_regionManagers[templateColumn.Title]);
        }
    }
}