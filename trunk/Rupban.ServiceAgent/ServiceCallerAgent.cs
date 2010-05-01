using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Rupban.Core;

using Rupban.ServiceAgent.RupbanBoardService;

namespace Rupban.ServiceAgent
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ServiceCallerAgent : IServiceCallerAgent,IRupbanBoardServiceCallback
    {
        private readonly RupbanBoardServiceClient _boardServiceClient ;
        
        public ServiceCallerAgent()
        {
            var instanceContext = new InstanceContext(this);
            _boardServiceClient = new RupbanBoardServiceClient(instanceContext);
        
           
        }

        public void MoveTicket(Ticket ticket, string sourceId, string targetId)
        {
            _boardServiceClient.MoveTicket(ticket, sourceId, targetId);
        }

        public void ViewTicketHistory()
        {
            _boardServiceClient.ViewTicketHistory();
        }

        public List<Project> GetCurrentProjectList()
        {
            return _boardServiceClient.GetCurrentProjectList().ToList<Project>();
        }

        public List<TemplateColumn> GetTemplateCollumList()
        {
            return _boardServiceClient.GetTemplateCollumList().ToList<TemplateColumn>();
        }


        public void TicketMoved(Ticket ticket, string sourceId, string targetId)
        {
            throw new NotImplementedException();
        }
    }
}
