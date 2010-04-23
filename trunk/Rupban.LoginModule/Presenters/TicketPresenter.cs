using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rupban.loginmodule.Controller;
using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
{
    public class TicketPresenter : ITicketPresenter
    {
        private ITicketController _ticketController;
        

        public TicketPresenter(ITicketView view, ITicketController ticketController)
        {
            View = view;
            View.SetModel(this);
            _ticketController = ticketController;
        }

        public ITicketView View
        {
            get ;
            set ;
        }
    }
}
