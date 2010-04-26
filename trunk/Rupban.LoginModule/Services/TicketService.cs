using System;
using Rupban.ServiceAgent;

namespace Rupban.LoginModule.Services
{
    public class TicketService : ITicketService
    {
        private readonly IServiceAgent _serviceAgent;

        public TicketService()
        {
            try
            {
                _serviceAgent = new ServiceAgent.ServiceAgent();
            }
            catch
            {
            }
            
        }

        public void MoveTicket()
        {
            _serviceAgent.MoveTicket();
        }

        public void ViewTicketHistory()
        {
            _serviceAgent.ViewTicketHistory();
        }

        public void PickTicket()
        {
            throw new NotImplementedException();
        }
    }
}