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
        private readonly InDevColumnController _panelColumnController;
        private readonly IInDevColumnService _panelColumnService;
        private readonly IEventAggregator _eventAggregator;

        public IInDevColumnView View
        {
            get;
            set;
        }
        public InDevColumnPresenter(IInDevColumnView view, InDevColumnController panelColumnController, IInDevColumnService panelColumnService, IEventAggregator eventAggregator)
        {
            _panelColumnController = panelColumnController;
            _panelColumnService = panelColumnService;
            _eventAggregator = eventAggregator;

            View = view;
            View.SetModel(this);
           
        }

    }
}