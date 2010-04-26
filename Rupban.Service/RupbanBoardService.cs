using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Rupban.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "RupbanBoardService" in both code and config file together.
    
    public class RupbanBoardService : IRupbanBoardService
    {
        private static readonly List<IRupbanBoardServiceDuplexCallback> subscribers = new List<IRupbanBoardServiceDuplexCallback>();

   
        public void MoveTicket()
        {

            subscribers.ForEach(delegate(IRupbanBoardServiceDuplexCallback callback)
            {
                if (((ICommunicationObject)callback).State == CommunicationState.Opened)
                {
                    callback.TicketMoved();
                }
                else
                {
                    subscribers.Remove(callback);
                }
            });
            
        }

        public bool Subscribe()
        {
            try
            {
                var callback = OperationContext.Current.GetCallbackChannel<IRupbanBoardServiceDuplexCallback>();
                if (!subscribers.Contains(callback))
                    subscribers.Add(callback);
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
                if (!subscribers.Contains(callback))
                    subscribers.Remove(callback);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
