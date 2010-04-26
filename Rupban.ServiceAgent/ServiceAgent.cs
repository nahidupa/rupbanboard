using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Rupban.ServiceAgent.RupbanBoardService;

namespace Rupban.ServiceAgent
{
    public class ServiceAgent : IServiceAgent
    {
        RupbanBoardServiceClient boardServiceClient ;
        public ServiceAgent()
        {
            var instanceContext = new InstanceContext(new CallbackHandler());
            boardServiceClient = new RupbanBoardServiceClient(instanceContext);
           
        }
        public void MoveTicket()
        {
            boardServiceClient.MoveTicket();
            
        }

        public void ViewTicketHistory()
        {
            throw new NotImplementedException();
        }
    }
}
