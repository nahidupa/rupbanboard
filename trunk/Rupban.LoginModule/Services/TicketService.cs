using System;
using Microsoft.Practices.Unity;
using Rupban.ServiceAgent;

namespace Rupban.LoginModule.Services
{
    public class TicketService : ITicketService
    {
        private readonly IServiceAgent _serviceAgent;

        public TicketService(IUnityContainer container)
        {
            try
            {
                _serviceAgent = container.Resolve<IServiceAgent>(); 
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