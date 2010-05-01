using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;
using System.Linq;
namespace Rupban.Core
{
    [DataContract]
    [KnownType(typeof(TemplateRow))]
    [KnownType(typeof(TemplateCell))]
    [KnownType(typeof(Ticket))]
    [KnownType(typeof(PeerBox))]
    [KnownType(typeof(Resource))]
    public class TemplateColumn
    {
        [DataMember]
        public string Id { set; get; }
        [DataMember]
        public string ColumnHeader { set; get; }
        [DataMember]
        private List<TemplateRow> _templateRows;

       
        [DataMember]
        public ColumnType ColumnType
        { set; get; }


        public TemplateColumn()
        {
            _templateRows = new List<TemplateRow>();
            Id = Guid.NewGuid().ToString();

            AddRow();
        }

        public List<TemplateRow> SetRows(List<TemplateRow> templateRows)
        {
            _templateRows = templateRows;
            return _templateRows;
        }
        public List<TemplateRow> GetRows()
        {
            return _templateRows;
        }

        private TemplateRow AddRow()
        {
            var templateRow = new TemplateRow();
            _templateRows.Add(templateRow);
            return templateRow;
        }

       
        public TemplateRow GetRowByIndex(int index)
        {
            return _templateRows[index];
        }

        public Ticket GetTicketById(string ticketId)
        {
            foreach (var templateRow in _templateRows)
            {
                return templateRow.GetAllTickets().SingleOrDefault(t => t.Id.Equals(ticketId));
            }
            return null;
        }

        public bool HasTicket(string ticketId)
        {
            foreach (var templateRow in _templateRows)
            {
                var ticket=templateRow.GetAllTickets().SingleOrDefault(t => t.Id.Equals(ticketId));
                if (ticket != null) return true;
            }
            return false;
        }

        public void RemoveTicket(string ticketId)
        {
            foreach (var templateRow in _templateRows)
            {
                var ticket = templateRow.GetAllTickets().SingleOrDefault(t => t.Id.Equals(ticketId));
                templateRow.RemoveItem(ticket);
            }
       }
    }
}
