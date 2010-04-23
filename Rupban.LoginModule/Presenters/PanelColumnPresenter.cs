using System;
using System.Collections.ObjectModel;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class PanelColumnPresenter : IPanelColumnPresenter
    {
        private readonly IPanelColumnController _panelColumnController;
        private readonly IPanelColumnService _panelColumnService;
        

        public IPanelColumnView View
        {
            get;
            set;
        }

        public void LoadBoardTicket(TemplateRow row)
        {
            _panelColumnController.LoadBoardTicketView(row);
        }

        public PanelColumnPresenter(IPanelColumnView view, IPanelColumnController panelColumnController, IPanelColumnService panelColumnService)
        {
            _panelColumnController = panelColumnController;
            _panelColumnService = panelColumnService;
            View = view;
            View.SetModel(this);
        }
    }
}