using System;
using Rupban.ServiceAgent;

namespace Rupban.LoginModule.Services
{
    public class TicketService : ITicketService
    {
        private readonly IServiceAgent _serviceAgent;

        public TicketService(IServiceAgent serviceAgent)
        {
            _serviceAgent = serviceAgent;
        }

        public void MoveTicket()
        {
            _serviceAgent.MoveTicket();
        }
    }
}