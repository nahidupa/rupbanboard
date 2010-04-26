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
        readonly RupbanBoardServiceClient boardServiceClient ;
        private readonly CallbackHandler _serverCallBack;

        public ServiceAgent()
        {
            _serverCallBack = new CallbackHandler();
            var instanceContext = new InstanceContext(_serverCallBack);
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

        public CallbackHandler GetCallbackHandler()
        {
            return _serverCallBack;
        }
    }
}
