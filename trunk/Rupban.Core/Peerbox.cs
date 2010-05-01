using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
namespace Rupban.Core
{
    [DataContract]
    public class PeerBox : TemplateCell
    {
        [DataMember]
        public Resource Resources
        {
            get;
            set;
        }

        public PeerBox()
        {
            _tickets=new List<Ticket>();
        }

        private List<Ticket> _tickets;

        [DataMember]
        public List<Ticket> Tickets
        {
            get { return _tickets; }
            set { _tickets = value; }
        }


        public bool HasTicket(string ticketId)
        {
            return _tickets.SingleOrDefault(t => t.Id.Equals(ticketId))!=null;
        }
        public List<Ticket> GetAllTicket()
        {
            return _tickets;
        }

        public void RemoveTicket(string ticketId)
        {
            var ticketToRemove=_tickets.SingleOrDefault(o => o.Id.Equals(ticketId));
            if(ticketToRemove!=null)
            {
                _tickets.Remove(ticketToRemove);
            }
        }

        public void AddItem(Ticket ticket)
        {
           _tickets.Add(ticket);
        }

        public Ticket GetTicketById(string ticketId)
        {
            return _tickets.SingleOrDefault(t => t.Id.Equals(ticketId));
        }
    }
}
