using System;
using System.Collections.Generic;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.LoginModule.Data;
using rupban.loginmodule.Presenters;
using Rupban.LoginModule.Presenters;
using Rupban.LoginModule.Views;
using Rupban.ServiceAgent;
using Rupban.UI.Infrastructure;
using System.Windows;
using Rupban.UI.Infrastructure.Event;
using System.Linq;
namespace Rupban.LoginModule.Controller
{
    public class RupbanBoardController : IRupbanBoardController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private readonly IEventAggregator _eventAggregator;
        private readonly IServiceLisnerAgent _serviceListenerAgent;
        private Dictionary<string,IRegionManager> _regionManagers;
        private Dictionary<string, IPanelColumnPresenter> _panelColumnPresenters;
        public RupbanBoardController(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _container = container;
            _eventAggregator = eventAggregator;
            _regionManagers = new Dictionary<string, IRegionManager>();
            _panelColumnPresenters = new Dictionary<string, IPanelColumnPresenter>();            
            _serviceListenerAgent = container.Resolve<IServiceLisnerAgent>();
            _serviceListenerAgent.TicketMovedCalBack += ServiceListenerAgentTicketMovedCalBack;
            
            _eventAggregator.GetEvent<TicketDropedEvent>().Subscribe(TicketDroped);
        
        }

        private void TicketDroped(TickedMoveEventArgs tickedMoveEventArgs)
        {
            if (tickedMoveEventArgs.Ticket != null)
            {
                Ticket ticket = tickedMoveEventArgs.Ticket;


                var targetRegionManager = _regionManagers[tickedMoveEventArgs.TargetColumnId];
                var targetRegion = targetRegionManager.Regions[RegionNames.TicketRegion];

                var sourceRegionManager = _regionManagers[tickedMoveEventArgs.SourceColumnId];
                var sourceRegion = sourceRegionManager.Regions[RegionNames.TicketRegion];
                var ticketView = sourceRegion.GetView(ticket.Id);

                sourceRegion.Remove(ticketView);

                
                targetRegion.Add(ticketView, ticket.Id);

                BoardData.SyncData(tickedMoveEventArgs);


                
                
            }
           
        }

        static void ServiceListenerAgentTicketMovedCalBack()
        {
            MessageBox.Show("CallBack");
        }

        
        //private IPanelColumnPresenter GetColumnContainsTicket()
        //{
        //    //_panelColumnPresenters.Select(p=>p.Value.TemplateColumn.)
        //    //return 
        //}



        public void LoadBoardColumnView(List<TemplateColumn> templateCollums)
        {
            var region = _regionManager.Regions[RegionNames.ColumnRegion];
            foreach (var templateCollum in templateCollums)
            {
                var panelColumnPresenter = _container.Resolve<IPanelColumnPresenter>();
                panelColumnPresenter.TemplateColumn = templateCollum;
                BoardData.AddVisulColumn(templateCollum.Id,panelColumnPresenter);
                var regionManager = region.Add(panelColumnPresenter.View, templateCollum.Id,true);
                _regionManagers.Add(templateCollum.Id, regionManager);
                _panelColumnPresenters.Add(templateCollum.Id, panelColumnPresenter);
                
            }
        }

       

        public void LoadRowView(TemplateColumn templateColumn)
        {
            _panelColumnPresenters[templateColumn.Id].LoadTicketView(_regionManagers[templateColumn.Id]);
        }
    }
}