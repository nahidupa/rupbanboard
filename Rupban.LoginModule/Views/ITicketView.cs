using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rupban.loginmodule.Presenters;

namespace rupban.loginmodule.Views
{
    public interface ITicketView
    {
        void SetModel(ITicketPresenter model);
    }
}
