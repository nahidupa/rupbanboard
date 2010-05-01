using System.Collections.Generic;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.Core;
using rupban.loginmodule.Presenters;
using Rupban.LoginModule.Presenters;
using Rupban.UI.Infrastructure;

namespace Rupban.LoginModule.Controller
{
    public class InDevColumnController : IInDevColumnController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IRegionManager _localRegionManager;
        private IRupbanBoardController _rupbanBoardController;
        private readonly IEventAggregator _eventAggregator;
        private readonly Dictionary<string, IRegionManager> _peerboxRegionManagers;

        public InDevColumnController(IRegionManager regionManager, IUnityContainer container, IRupbanBoardController rupbanBoardController, IEventAggregator eventAggregator)
        {
            _rupbanBoardController = rupbanBoardController;
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
            _container = container;
            _peerboxRegionManagers = new Dictionary<string, IRegionManager>();
        }

        public void LoadBoardPeerBoxView(TemplateRow row, IRegionManager localRegionManager)
        {

            _localRegionManager = localRegionManager;

            var region = localRegionManager.Regions[RegionNames.PeerBoxRegion];

            foreach (var peerBox in row.GetAllPeerBox())
            {
                var peerPresenter = _container.Resolve<IPeerBoxPresenter>();
                peerPresenter.PeerBox = peerBox;

                _rupbanBoardController.AddTemplateCelHolderPresenter(peerBox.Id, peerPresenter);
                var peerboxRegion = region.Add(peerPresenter.View, peerBox.Id, true);
                _peerboxRegionManagers.Add(peerBox.Id, peerboxRegion);
                
                var idleReourceRegion = peerboxRegion.Regions[RegionNames.IdleReourceRegion];
                var idleResourcePresenter = _container.Resolve<IIdleResourcePresenter>();

                idleReourceRegion.Add(idleResourcePresenter.View, peerBox.Id);

                foreach (var ticket in peerBox.GetAllTicket())
                {
                    var ticketRegion = peerboxRegion.Regions[RegionNames.TicketRegion];
                    var ticketPresenter = _container.Resolve<ITicketPresenter>();
                    ticketPresenter.Ticket = ticket;
                    ticketRegion.Add(ticketPresenter.View, ticket.Id);
                    
             

                }
        
        
            }



        }

        public Dictionary<string, IRegionManager> GetPeerboxRegionManagers()
        {
            return _peerboxRegionManagers;
        }
    }
}