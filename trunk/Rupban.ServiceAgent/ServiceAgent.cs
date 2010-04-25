using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rupban.ServiceAgent.RupbanBoardService;

namespace Rupban.ServiceAgent
{
    public class ServiceAgent : IServiceAgent
    {
        RupbanBoardServiceClient boardServiceClient = new RupbanBoardServiceClient();
        public ServiceAgent()
        {
           
        }
        public void MoveTicket()
        {
            boardServiceClient.MoveTicket();
            
        }
    }
}
