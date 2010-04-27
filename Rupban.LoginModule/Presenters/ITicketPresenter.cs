using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rupban.Core;
using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
{
   public  interface ITicketPresenter
    {
       ITicketView View { get; set; }
       Ticket Ticket { set; get; }
       
    }
}
