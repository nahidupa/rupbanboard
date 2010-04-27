﻿using System;
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
        private static List<IRupbanBoardServiceDuplexCallback> _subscribers;
        private static ProjectKeeper _projectKeeper;
        public RupbanBoardService()
        {
            _subscribers = new List<IRupbanBoardServiceDuplexCallback>();
            _projectKeeper=new ProjectKeeper();
        }

   
        public void MoveTicket()
        {
            //_projectKeeper.MoveTicket();
            NotifyAllClient();
        }

        private static void NotifyAllClient()
        {
            _subscribers.ForEach(delegate(IRupbanBoardServiceDuplexCallback callback)
                                     {
                                         if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                                         {
                                             callback.TicketMoved();
                                         }
                                         else
                                         {
                                             _subscribers.Remove(callback);
                                         }
                                     });
        }

        public bool Subscribe()
        {
            try
            {
                var callback = OperationContext.Current.GetCallbackChannel<IRupbanBoardServiceDuplexCallback>();
                if (!_subscribers.Contains(callback))
                    _subscribers.Add(callback);
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
                if (!_subscribers.Contains(callback))
                    _subscribers.Remove(callback);
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