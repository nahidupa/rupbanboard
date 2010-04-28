using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rupban.Core;
using rupban.loginmodule.Presenters;

namespace rupban.loginmodule.Views
{
    public interface ITicketView
    {
        void SetModel(ITicketPresenter model);
        Ticket GetTicket();
    }
}
