using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Rupban.Core;
using Rupban.Server;

namespace Rupban.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RupbanBoardService" in both code and config file together.
    
    
    public class RupbanBoardService : IRupbanBoardService
    {
        private static readonly List<IRupbanBoardServiceDuplexCallback> Subscribers=new List<IRupbanBoardServiceDuplexCallback>();
        private static ProjectKeeper _projectKeeper=new ProjectKeeper();
        public RupbanBoardService()
        {
           
        }

   
        public void MoveTicket(Ticket ticket, string sourceId, string targetId)
        {
            _projectKeeper.MoveTicket(ticket, sourceId, targetId);
            NotifyAllClient(ticket, sourceId, targetId);
        }

        private static void NotifyAllClient(Ticket ticket, string sourceId, string targetId)
        {
            Subscribers.ForEach(delegate(IRupbanBoardServiceDuplexCallback callback)
                                     {
                                         if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                                         {
                                             callback.TicketMoved(ticket, sourceId, targetId);
                                         }
                                         else
                                         {
                                             Subscribers.Remove(callback);
                                         }
                                     });
        }

        public bool Subscribe()
        {
            try
            {
                var callback = OperationContext.Current.GetCallbackChannel<IRupbanBoardServiceDuplexCallback>();
                if (!Subscribers.Contains(callback))
                    Subscribers.Add(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Unsubscribe()
        {
            try
            {
                var callback = OperationContext.Current.GetCallbackChannel<IRupbanBoardServiceDuplexCallback>();
                if (!Subscribers.Contains(callback))
                    Subscribers.Remove(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void ViewTicketHistory()
        {
            _projectKeeper.ViewTicketHistory();
        }

        public List<Project> GetCurrentProjectList()
        {
          return _projectKeeper.GetCurrentProjectList();
        }

        public List<TemplateColumn> GetTemplateCollumList()
        {
            return _projectKeeper.GetTemplateCollumList();
        }
    }
}
