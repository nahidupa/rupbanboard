using System;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Regions;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class InDevColumnPresenter : IInDevColumnPresenter
    {
     
        private readonly IInDevColumnController _inDevColumnController;
        private readonly IInDevColumnService _panelColumnService;
        private readonly IEventAggregator _eventAggregator;
        public TemplateColumn TemplateColumn{ set; get;}
       

        public IInDevColumnView View
        {
            get;
            set;
        }
        public InDevColumnPresenter(IInDevColumnView view, IInDevColumnController inDevColumnController, IInDevColumnService panelColumnService, IEventAggregator eventAggregator)
        {
            _inDevColumnController = inDevColumnController;
            _panelColumnService = panelColumnService;
            _eventAggregator = eventAggregator;

            View = view;
            View.SetModel(this);
           
        }
        public void LoadPeerView(IRegionManager regionManager)
        {
            var rows = TemplateColumn.GetRows();
            foreach (var templateRow in rows)
            {
                _inDevColumnController.LoadBoardPeerBoxView(templateRow, regionManager);
            }
        }

        public TemplateCell TemplateCell
        {
            set; get;
        }
    }
}