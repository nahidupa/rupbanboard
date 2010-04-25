using System;
using rupban.loginmodule.Controller;
using Rupban.LoginModule.Services;

namespace rupban.loginmodule.Commands
{
    public class ViewTicketHistoryCommand : IViewTicketHistoryCommand
    {
        private readonly ITicketService _ticketService;
        private readonly ITicketController _ticketController;


        public ViewTicketHistoryCommand(ITicketService ticketService, ITicketController ticketController)
        {
            _ticketService = ticketService;
            _ticketController = ticketController;
        }

        public void Execute(object parameter)
        {
            _ticketService.ViewTicketHistory();

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}