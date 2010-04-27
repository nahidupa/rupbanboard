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

        public void MoveTicket(string ticketId, string currentColumnName, string destinationColumnName)
        {
            _boardServiceClient.MoveTicket(ticketId, currentColumnName, destinationColumnName);
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



        #region IRupbanBoardServiceCallback Members

        public void TicketMoved()
        {
            //throw new NotImplementedException();
        }

        #endregion
    }
}
