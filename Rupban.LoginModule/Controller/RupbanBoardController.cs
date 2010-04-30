using System;
using System.Collections.Generic;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.LoginModule.Presenters;
using Rupban.ServiceAgent;
using Rupban.UI.Infrastructure;
using System.Windows;
using Rupban.UI.Infrastructure.Event;

namespace Rupban.LoginModule.Controller
{
    public class RupbanBoardController : IRupbanBoardController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private readonly IEventAggregator _eventAggregator;
        private readonly IServiceLisnerAgent _serviceListenerAgent;
        private Dictionary<string, IRegionManager> _regionManagers;
        private Dictionary<string, IColumnPresenter> _columnPresenters;


        private Dictionary<string, IPeerBoxPresenter> _templateCelHolderPresenters;
        public RupbanBoardController(IRegionManager regionManager, IUnityContainer container, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _container = container;
            _eventAggregator = eventAggregator;
            _regionManagers = new Dictionary<string, IRegionManager>();
            _columnPresenters = new Dictionary<string, IColumnPresenter>();
            _templateCelHolderPresenters = new Dictionary<string, IPeerBoxPresenter>();
            _serviceListenerAgent = container.Resolve<IServiceLisnerAgent>();
            _serviceListenerAgent.TicketMovedCalBack += ServiceListenerAgentTicketMovedCalBack;

            _eventAggregator.GetEvent<TicketDropedEvent>().Subscribe(TicketDroped);

        }

        private void TicketDroped(TickedMoveEventArgs tickedMoveEventArgs)
        {
            if (tickedMoveEventArgs.Ticket != null)
            {
                Ticket ticket = tickedMoveEventArgs.Ticket;

                var targetRegion = GetTatgetRegion(tickedMoveEventArgs);

                var sourceRegion = GetSourceRegion(tickedMoveEventArgs);

                var ticketView = sourceRegion.GetView(ticket.Id);

                RemovefromData(tickedMoveEventArgs.SourceId,ticket.Id);
                
                sourceRegion.Remove(ticketView);

                AddToData(tickedMoveEventArgs.TargetId,ticket);

                targetRegion.Add(ticketView, ticket.Id);

                //BoardData.SyncData(tickedMoveEventArgs);

               


            }

        }

        private void AddToData(string targetId,Ticket ticket)
        {
            if (_columnPresenters.ContainsKey(targetId))
            {
                _columnPresenters[targetId].TemplateColumn.GetRows()[0].AddItem(ticket);
            }
            else if (_templateCelHolderPresenters.ContainsKey(targetId))
            {
                _templateCelHolderPresenters[targetId].PeerBox.AddItem(ticket);
            }
        }

        private void RemovefromData(string sourceId, string ticketId)
        {
            if (_columnPresenters.ContainsKey(sourceId))
            {
                _columnPresenters[sourceId].TemplateColumn.RemoveTicket(ticketId);
            }
            else if (_templateCelHolderPresenters.ContainsKey(sourceId))
            {
                _templateCelHolderPresenters[sourceId].PeerBox.RemoveTicket(ticketId);
            }
        }


        private IRegion GetSourceRegion(TickedMoveEventArgs tickedMoveEventArgs)
        {
            if (_regionManagers.ContainsKey(tickedMoveEventArgs.SourceId))
            {
                var sourceRegionManager = _regionManagers[tickedMoveEventArgs.SourceId];
                return sourceRegionManager.Regions[RegionNames.TicketRegion];
            }
            else
            {

                var inDevColumnController = _container.Resolve<IInDevColumnController>();
                var regionManagers = inDevColumnController.GetPeerboxRegionManagers();
                if (regionManagers.ContainsKey(tickedMoveEventArgs.SourceId))
                {
                    var sourceRegionManager = regionManagers[tickedMoveEventArgs.SourceId];
                    return sourceRegionManager.Regions[RegionNames.TicketRegion];
                }


            }
            return null;
        }

        private IRegion GetTatgetRegion(TickedMoveEventArgs tickedMoveEventArgs)
        {
            if (_regionManagers.ContainsKey(tickedMoveEventArgs.TargetId))
            {
                var targetRegionManager = _regionManagers[tickedMoveEventArgs.TargetId];
                return targetRegionManager.Regions[RegionNames.TicketRegion];
            }
            else
            {
                var inDevColumnController = _container.Resolve<IInDevColumnController>();
                var regionManagers = inDevColumnController.GetPeerboxRegionManagers();

                if (regionManagers.ContainsKey(tickedMoveEventArgs.TargetId))
                {
                    var targetRegionManager = regionManagers[tickedMoveEventArgs.TargetId];
                    return targetRegionManager.Regions[RegionNames.TicketRegion];
                }


            }
            return null;
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
                if (templateCollum.ColumnType == ColumnType.TicketHolderColumn)
                {
                    var panelColumnPresenter = _container.Resolve<IPanelColumnPresenter>();
                    panelColumnPresenter.TemplateColumn = templateCollum;
                    //_columnPresenters.Add(templateCollum.Id, panelColumnPresenter);
                    var regionManager = region.Add(panelColumnPresenter.View, templateCollum.Id, true);
                    _regionManagers.Add(templateCollum.Id, regionManager);
                    _columnPresenters.Add(templateCollum.Id, panelColumnPresenter);

                }
                else if (templateCollum.ColumnType == ColumnType.PeerBoxHolderColumn)
                {
                    var inDevColumnPresenter = _container.Resolve<InDevColumnPresenter>();
                    inDevColumnPresenter.TemplateColumn = templateCollum;
                    //_templateCelHolderPresenters.Add(templateCollum.Id, inDevColumnPresenter);
                    var regionManager = region.Add(inDevColumnPresenter.View, templateCollum.Id, true);
                    _regionManagers.Add(templateCollum.Id, regionManager);
                    _columnPresenters.Add(templateCollum.Id, inDevColumnPresenter);

                }
            }
        }



        public void LoadRowView(TemplateColumn templateColumn)
        {
            if (templateColumn.ColumnType == ColumnType.TicketHolderColumn)
            {
                ((IPanelColumnPresenter)_columnPresenters[templateColumn.Id]).LoadTicketView(_regionManagers[templateColumn.Id]);
            }
            else if (templateColumn.ColumnType == ColumnType.PeerBoxHolderColumn)
            {
                ((IInDevColumnPresenter)_columnPresenters[templateColumn.Id]).LoadPeerView(_regionManagers[templateColumn.Id]);

            }
        }

        public string GetSourceTemplateTicketId(string ticketId)
        {
            foreach (var panelColumnPresenter in _columnPresenters.Values)
            {
                if (panelColumnPresenter.TemplateColumn.HasTicket(ticketId))
                    return panelColumnPresenter.TemplateColumn.Id;
            }
            foreach (var templateCelPresenter in _templateCelHolderPresenters.Values)
            {
                if (templateCelPresenter is IPeerBoxPresenter)
                {

                    var peerBoxPresenter = (IPeerBoxPresenter)templateCelPresenter;
                    var peerBox = ((PeerBox)peerBoxPresenter.PeerBox);
                    if (peerBox.HasTicket(ticketId))
                        return peerBox.Id;
                }
            }
            return null;
        }

        public void AddTemplateCelHolderPresenter(string id, IPeerBoxPresenter peerBoxPresenter)
        {
            _templateCelHolderPresenters.Add(id, peerBoxPresenter);
        }
    }
}